using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
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
                AddCrewStatsToTotals(CrewList.CrewListing[crewID].CrewStats);

                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    int implantID = (int)team.CrewMembers[crewIndex].ImplantIDs[implantIndex];
                    AddImplantStatsToTotals(ImplantList.ImplantListing[implantID].Stat);
                }
            }
        }

        private void AddCrewStatsToTotals(StatCombination[] crewStats)
        {

        }

        private void AddImplantStatsToTotals(StatCombination implantStats)
        {

        }
    }
}
