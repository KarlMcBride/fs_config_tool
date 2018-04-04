using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Content;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool
{
    public partial class MainForm : Form
    {
        private ConfigManager config;

        public MainForm()
        {
            InitializeComponent();

            config = new ConfigManager();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            config.LoadConfig();

            PopulateCrewBox();
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

            //CrewSetBoxMain.Parent = this;
        }
    }
}
