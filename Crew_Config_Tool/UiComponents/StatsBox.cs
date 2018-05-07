using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class StatsBox : UserControl
    {
        private StatCombination[] StatMathList;

        public StatsBox()
        {
            InitializeComponent();
        }

        private void PopulateStatMathList()
        {
            int numOfStats = (int)StatType.ENERGY_EFFICIENCY + 1;

            StatMathList = new StatCombination[numOfStats];

            for (int index = 0; index < numOfStats; index++)
            {
                StatMathList[index] = StatList.StatsListing[index];
            }
        }

        public void UpdateAndShowStats(TeamConfig team)
        {
            if (StatMathList == null)
            {
                PopulateStatMathList();
            }

            ResetStats();
            CalculateStats(team);
            ShowStats();
        }

        private void ResetStats()
        {
            for (int index = 0; index < StatMathList.Length; index++)
            {
                StatMathList[index].Value = 0;
            }
        }

        private void CalculateStats(TeamConfig team)
        {
            // Cycle through all crew members and their respective implants
            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                CrewEnum crew = team.CrewMembers[crewIndex].CrewID;

                // Ignore NONE crew
                if (crew != CrewEnum.NONE)
                {
                    int crewID = (int)team.CrewMembers[crewIndex].CrewID;
                    AddCrewStatsToTotals(CrewList.CrewListing[crewID].CrewStats);
                }


                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    ImplantEnum implant = team.CrewMembers[crewIndex].ImplantIDs[implantIndex];

                    // Ignore NONE implants
                    if (implant != ImplantEnum.NONE)
                    {
                        int implantID = (int)team.CrewMembers[crewIndex].ImplantIDs[implantIndex];
                        AddStatToTotals(ImplantList.ImplantListing[implantID].Stat);
                    }
                }
            }
        }

        private void AddCrewStatsToTotals(StatCombination[] crewStats)
        {
            for (int statIndex = 0; statIndex < crewStats.Length; statIndex++)
            {
                AddStatToTotals(crewStats[statIndex]);
            }
        }

        private void AddStatToTotals(StatCombination stat)
        {
            int statIndex = (int)stat.Type;

            StatMathList[statIndex].Value += stat.Value;
        }

        private void ShowStats()
        {

        }
    }
}
