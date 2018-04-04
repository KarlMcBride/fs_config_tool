using FS_Crew_Config_Tool.Classes;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class CrewSetBox : UserControl
    {
        private CrewBox[] crewBoxArray;

        public CrewSetBox()
        {
            InitializeComponent();

            crewBoxArray = new CrewBox[] { CrewBox0, CrewBox1, CrewBox2, CrewBox3, CrewBox4 };
        }

        public void DisplaySelectedTeam(TeamConfig team, CrewSetBox parent)
        {
            for (int index = 0; index < 5; index++)
            {
                crewBoxArray[index].Parent = parent;
                crewBoxArray[index].DisplaySelectedCrew(team.CrewMembers[index]);
            }
        }
    }
}
