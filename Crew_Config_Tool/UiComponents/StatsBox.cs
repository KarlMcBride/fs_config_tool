using FS_Crew_Config_Tool.Classes;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class StatsBox : UserControl
    {
        public StatsBox()
        {
            InitializeComponent();
        }

        public void GenerateStats(TeamConfig team)
        {
            CalculateAttackStats(team);
        }

        private void CalculateAttackStats(TeamConfig team)
        {
            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                int crewID = (int)team.CrewMembers[crewIndex].CrewID;

                //if (CrewList.CrewListing[crewID].

                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {

                }
            }
        }
    }
}
