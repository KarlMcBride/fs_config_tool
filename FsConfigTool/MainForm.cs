using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Config_Tool.Classes.Listings;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace FS_Config_Tool
{
    public partial class MainForm : Form
    {
        private ConfigManager config;
        private UiOffload uiOffload;

        private BackgroundWorker backgroundWorker;
        private const int BG_WORKER_INTERVAL_MS = 1000;

        private const int ITERATIONS_TO_UPDATE = 60;

        private RadioButton[] crewFilterArray;
        private RadioButton[] implantFilterArray;

        public MainForm()
        {
            InitializeComponent();

            config = new ConfigManager();
            uiOffload = new UiOffload();
            StatsBox.PopulateStatMathList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            config.LoadConfig();

            PopulateCrewBox();

            ConfigureToolTips();

            LabelFsRunningWarning.Visible = Utilities.CheckIfFracSpaceIsRunning("Fractured Space");

            ConfigureBackgroundWorker();

            ConfigureCrewAndImplantRemovalCallbacks();

            crewFilterArray = new RadioButton[] { RadioButtonCrewCag, RadioButtonCrewCaptain, RadioButtonCrewComms,
                                                  RadioButtonCrewEngineer, RadioButtonCrewJump, RadioButtonCrewNav,
                                                  RadioButtonCrewRepair, RadioButtonCrewTactical, RadioButtonCrewUtility };

            implantFilterArray = new RadioButton[] { RadioButtonImpAtk, RadioButtonImpDef, RadioButtonImpUtil };
        }

        private void ConfigureBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();
        }

        private void ConfigureCrewAndImplantRemovalCallbacks()
        {
            CrewSetBoxMain.CrewMemberDoubleClicked += RemoveSelectedCrewMember;
            CrewSetBoxMain.ImplantDoubleClicked += RemoveSelectedCrewMemberImplant;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool fsRunning = false;

            int iterations = ITERATIONS_TO_UPDATE;
            string playerCount = string.Empty;

            // Check for new version once at startup
            if (Utilities.CheckLatestSoftwareVersion() == Utilities.UPDATE_STATUS.NEW_VERSION_AVAILABLE)
            {
                string message = "Version " + Utilities.LatestVersion + " is available and contains the following changes.\n\n";

                message += Utilities.LatestNotes + "\n\n";
                message += "Would you like to get the next version?";

                DialogResult result = MessageBox.Show(message, "Version " + Utilities.LatestVersion + " available", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Process.Start(Utilities.LatestLink);
                }
            }

            while (true)
            {
                fsRunning = Utilities.CheckIfFracSpaceIsRunning("Fractured Space");

                if (iterations >= ITERATIONS_TO_UPDATE)
                {
                    playerCount = Utilities.GetOnlinePlayerCount();
                    iterations = 0;
                }

                BeginInvoke(new MethodInvoker(delegate
                {
                    UpdateFsRunningWarningLabel(fsRunning);
                    UpdateCcuLabel(playerCount);
                }));

                Thread.Sleep(BG_WORKER_INTERVAL_MS);
            }
        }

        private void UpdateFsRunningWarningLabel(bool fsRunning)
        {
            if (fsRunning)
            {
                // Toggle BG colour on each pass
                if (LabelFsRunningWarning.BackColor == System.Drawing.Color.Red)
                {
                    LabelFsRunningWarning.BackColor = System.Drawing.Color.Transparent;
                }
                else
                {
                    LabelFsRunningWarning.BackColor = System.Drawing.Color.Red;
                }
            }

            LabelFsRunningWarning.Visible = fsRunning;
        }

        private void UpdateCcuLabel(string currrentCCU)
        {
            labelCcuCount.Text = "CCU: " + currrentCCU;
        }

        private void ConfigureToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(LabelFsRunningWarning, "Fractured Space.exe is still running.\n" +
                                                      "To ensure that no config changes are lost,\n" +
                                                      "it is recommended to close down FS, save\n" +
                                                      "configs here and restart.");
        }

        private void ButtonSortAlpha_Click(object sender, EventArgs e)
        {
            config.SortAlphabetically();
            PopulateCrewBox();
        }

        private void PopulateCrewBox()
        {
            if (ListBoxCrews.Items.Count > 0)
            {
                ListBoxCrews.Items.Clear();
            }

            foreach (CrewLines crewLine in config.DataLists.CrewData)
            {
                ListBoxCrews.Items.Add(crewLine.CrewName);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            config.SaveConfig();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;
            int itemCount = ListBoxCrews.Items.Count;

            bool deleteSuccessful = config.DeleteSelectedCrewFromList(selectedIndex);

            if (deleteSuccessful)
            {
                ListBoxCrews.Items.RemoveAt(selectedIndex);

                ListBoxCrews.SelectedIndex = config.GetNextSelectableCrewInList(selectedIndex, itemCount);
            }
        }

        private void ListBoxCrews_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;

            if (selectedIndex != -1)
            {
                RunCrewUpdates(selectedIndex);

                SetDeleteButtonState(selectedIndex);
            }
            else
            {
                CrewSetBoxMain.ClearDisplayedTeam(CrewSetBoxMain);
            }
        }

        private void SetDeleteButtonState(int index)
        {
            // Index of -1 indicates that no item is selected
            ButtonDelete.Enabled = (index > -1) ? true : false;
        }

        private void CheckBoxCrewFilters_CheckedChanged(object sender, EventArgs e)
        {
            uiOffload.PopulateCrewListing(crewFilterArray, ref ListViewFilteredCrew);
        }

        private void CheckBoxImplantFilters_CheckedChanged(object sender, EventArgs e)
        {
            uiOffload.PopulateImplantListing(implantFilterArray, ref ListViewImplants);
        }

        private void ListViewFilteredCrew_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string crewName = ListViewFilteredCrew.FocusedItem.Text;
            int selectedIndex = ListBoxCrews.SelectedIndex;

            bool addSuccessful = config.AddSelectedMemberToSelectedCrew(crewName, selectedIndex);

            if (addSuccessful)
            {
                RunCrewUpdates(selectedIndex);
            }
        }

        private void ListViewImplants_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedCrewIndex = ListBoxCrews.SelectedIndex;
            string implantName = ListViewImplants.FocusedItem.Text;

            bool addSuccessful = false;

            // If shift is down, attempt to apply the implant to each crew member
            if (ModifierKeys == Keys.Shift)
            {
                for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
                {
                    addSuccessful |= config.AddSelectedImplantToNextFreeSlot(implantName, selectedCrewIndex);
                }
            }
            else
            {
                addSuccessful = config.AddSelectedImplantToNextFreeSlot(implantName, selectedCrewIndex);
            }

            if (addSuccessful)
            {
                RunCrewUpdates(selectedCrewIndex);
            }
        }

        public void RemoveSelectedCrewMember(object sender, CrewArgs args)
        {
            int selectedCrewIndex = ListBoxCrews.SelectedIndex;

            bool removeSuccessful = false;

            if (ModifierKeys == Keys.Shift)
            {
                for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
                {
                    removeSuccessful |= config.RemoveSelectedCrewMember(selectedCrewIndex, index);
                }
            }
            else
            {
                removeSuccessful = config.RemoveSelectedCrewMember(selectedCrewIndex, args.CrewIndex);
            }

            if (removeSuccessful)
            {
                RunCrewUpdates(selectedCrewIndex);
            }
        }

        public void RemoveSelectedCrewMemberImplant(object sender, CrewImplantArgs args)
        {
            int selectedCrewIndex = ListBoxCrews.SelectedIndex;

            bool removeSuccessful = false;

            if (ModifierKeys == Keys.Shift)
            {
                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    CrewImplantArgs uiArguments = new CrewImplantArgs(args.CrewIndex, implantIndex);

                    removeSuccessful |= config.RemoveSelectedCrewImplant(selectedCrewIndex, uiArguments);
                }
            }
            else
            {
                removeSuccessful = config.RemoveSelectedCrewImplant(selectedCrewIndex, args);
            }

            if (removeSuccessful)
            {
                RunCrewUpdates(selectedCrewIndex);
            }
        }

        private void RunCrewUpdates(int selectedCrewIndex)
        {
            CrewSetBoxMain.DisplaySelectedTeam(config.DataLists.CrewData[selectedCrewIndex].Team, CrewSetBoxMain);
            StatsBox.UpdateAndShowStats(config.DataLists.CrewData[selectedCrewIndex].Team);
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            string crewName = Interaction.InputBox("Enter the name for a new crew", "Create New Crew", "");

            AddNewCrewToLists(crewName);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            ShipSelector shipSelector = new ShipSelector();
            shipSelector.GenerateButtonClicked += GenerateSelectedShips;

            shipSelector.ShowDialog();
        }

        private void GenerateSelectedShips(object sender, ShipArgs shipArgs)
        {
            for (int index = 0; index < shipArgs.ArrayLength; index++)
            {
                if (shipArgs.ShipSelectionArray[index])
                {
                    string shipName = ShipList.ShipListing[index].Name;

                    AddNewCrewToLists(shipName);
                }
            }
        }

        private void AddNewCrewToLists(string crewName)
        {
            config.AddNewCrew(crewName);
            ListBoxCrews.Items.Add(crewName);
        }

        private void ButtonRenameSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;
            if (selectedIndex >= 0)
            {
                string currentName = ListBoxCrews.Items[selectedIndex].ToString();

                string newCrewName = Interaction.InputBox("Enter the name for [" + currentName + "]", "Rename Crew", "");

                config.RenameCrew(selectedIndex, newCrewName);

                ListBoxCrews.Items[selectedIndex] = newCrewName;
            }
        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (config.UnsavedChangesPresent)
            {
                DialogResult result = MessageBox.Show("Do you wish to save your changes?",
                                        "Unsaved Changes Present", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    config.SaveConfig();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
