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
            for (int index = 0; index < 3; index++)
            {
                pictureBoxImplantArray[index].Parent = PictureBoxCrew;
            }
        }

        public void DisplaySelectedCrew(TeamConfig.EnumeratedCrewMember crew)
        {
            PictureBoxCrew.Image = Utilities.GetCrewImageByIndex((int)crew.CrewID);

            for (int index = 0; index < 3; index++)
            {
                pictureBoxImplantArray[index].Image = Utilities.GetImplantImageByIndex((int)crew.ImplantIDs[index]);
            }
        }

        /// <summary>
        /// Unit test method - checks whether the crewbox crew image has been set
        /// </summary>
        /// <returns>True if non-null, false if null</returns>
        public bool CheckDisplayedCrewImage()
        {
            return (PictureBoxCrew.Image != null);
        }

        /// <summary>
        /// Unit test method - checks whether the crewbox implant image has been set
        /// </summary>
        /// <param name="index">Implant index to check</param>
        /// <returns>True if non-null, false if null</returns>
        public bool CheckDisplayedImplantImage(int index)
        {
            return (pictureBoxImplantArray[index].Image != null);
        }
    }
}
