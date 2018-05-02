using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.UiComponents;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool
{
    public partial class MainForm : Form
    {
        private ConfigManager config;
        private UiOffload uiOffload;

        private BackgroundWorker backgroundWorker;
        private const int BG_WORKER_INTERVAL_MS = 1000;

        private const int ITERATIONS_TO_UPDATE_CCU = 60;

        private CheckBox[] crewFilterArray;
        private CheckBox[] implantFilterArray;

        public MainForm()
        {
            InitializeComponent();

            config = new ConfigManager();
            uiOffload = new UiOffload();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            config.LoadConfig();

            PopulateCrewBox();

            ConfigureToolTips();

            LabelFsRunningWarning.Visible = Utilities.CheckIfFracSpaceIsRunning("Fractured Space");

            ConfigureBackgroundWorker();

            crewFilterArray = new CheckBox[] { CheckBoxCrewCag, CheckBoxCrewCaptain, CheckBoxCrewComms, CheckBoxCrewEngineer, CheckBoxCrewJump,
                                               CheckBoxCrewNav, CheckBoxCrewRepair, CheckBoxCrewTactical, CheckBoxCrewUtility };

            implantFilterArray = new CheckBox[] { CheckBoxImpAtk, CheckBoxImpDef, CheckBoxImpUtil };
        }

        private void ConfigureBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool fsRunning = false;

            int iterations = ITERATIONS_TO_UPDATE_CCU;
            string playerCount = string.Empty;

            while (true)
            {
                fsRunning = Utilities.CheckIfFracSpaceIsRunning("Fractured Space");

                if (iterations >= ITERATIONS_TO_UPDATE_CCU)
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

            foreach (ConfigManager.CrewLines crewLine in config.CrewData)
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

                ListBoxCrews.SelectedIndex = config.GetNextSelectableItem(selectedIndex, itemCount);
            }
        }

        private void ListBoxCrews_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;

            if (selectedIndex != -1)
            {
                CrewSetBoxMain.DisplaySelectedTeam(config.CrewData[selectedIndex].Team, CrewSetBoxMain);

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

            config.AddSelectedMemberToSelectedCrew(crewName, ListBoxCrews.SelectedIndex);
        }
    }
}
