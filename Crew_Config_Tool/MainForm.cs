using FS_Crew_Config_Tool.Classes;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool
{
    public partial class MainForm : Form
    {
        private ConfigManager config;

        private BackgroundWorker fsRunningBgWorker;

        public MainForm()
        {
            InitializeComponent();

            config = new ConfigManager();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            config.LoadConfig();

            PopulateCrewBox();

            ConfigureToolTips();

            LabelFsRunningWarning.Visible = Utils.CheckIfFracSpaceIsRunning("Fractured Space");

            ConfigureBackgroundWorker();
        }

        private void ConfigureBackgroundWorker()
        {
            fsRunningBgWorker = new BackgroundWorker();
            fsRunningBgWorker.DoWork += FsRunningBgWorker_DoWork;
            fsRunningBgWorker.RunWorkerAsync();
        }

        private void FsRunningBgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                BeginInvoke(new MethodInvoker(delegate
                {
                    UpdateFsRunningWarningLabel();
                }));

                Thread.Sleep(1000);
            }
        }

        private void UpdateFsRunningWarningLabel()
        {
            bool warningActive = Utils.CheckIfFracSpaceIsRunning("Fractured Space");

            if (warningActive)
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

            LabelFsRunningWarning.Visible = warningActive;
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

        private void ListBoxCrews_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;

            CrewSetBoxMain.DisplaySelectedTeam(config.CrewData[selectedIndex].Team, CrewSetBoxMain);
        }
    }
}
