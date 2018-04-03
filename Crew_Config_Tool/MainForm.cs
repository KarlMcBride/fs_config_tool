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

        private PictureBox[] crewPictureBoxes;

        public MainForm()
        {
            InitializeComponent();

            config = new ConfigManager();

            crewPictureBoxes = new PictureBox[] { PictureBoxCrew0, PictureBoxCrew1, PictureBoxCrew2, PictureBoxCrew3, PictureBoxCrew4 };
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

        private void ListBoxCrews_SelectedINdexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxCrews.SelectedIndex;

            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                int imageIndex = (int)config.CrewData[selectedIndex].Team.CrewMembers[crewIndex].CrewID;

                crewPictureBoxes[crewIndex].Image = Utils.GetCrewImageByIndex(imageIndex);
            }

            PictureBoxCrew0Slot0.Image = Utils.GetImplantImageByIndex(selectedIndex);

            //Bitmap implant = ImplantResources.ATTACK_DAMAGE;
            //implant.MakeTransparent(implant.GetPixel(0, 0));
        }
    }
}
