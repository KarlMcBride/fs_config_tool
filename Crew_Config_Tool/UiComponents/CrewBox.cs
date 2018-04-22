using FS_Crew_Config_Tool.Classes;
using System;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class CrewBox : UserControl
    {
        private PictureBox[] pictureBoxImplantArray;

        public CrewBox()
        {
            InitializeComponent();

            pictureBoxImplantArray = new PictureBox[] { PictureBoxImplant0, PictureBoxImplant1, PictureBoxImplant2 };
        }

        private void CrewBox_Load(object sender, EventArgs e)
        {
            PictureBoxImplant0.Parent = PictureBoxCrew;
            PictureBoxImplant1.Parent = PictureBoxCrew;
            PictureBoxImplant2.Parent = PictureBoxCrew;
        }

        public void DisplaySelectedCrew(TeamConfig.EnumeratedCrewMember crew)
        {
            PictureBoxCrew.Image = Utilities.GetCrewImageByIndex((int)crew.CrewID);

            for (int index = 0; index < 3; index++)
            {
                pictureBoxImplantArray[index].Image = Utilities.GetImplantImageByIndex((int)crew.ImplantIDs[index]);
            }
        }
    }
}
