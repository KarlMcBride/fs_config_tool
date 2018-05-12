using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
using System;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    public partial class StatsBox : UserControl
    {
        private StatCombination[] StatMathList;

        private StatPair[] statPairsAttack;
        private StatPair[] statPairsDefense;
        private StatPair[] statPairsUtility;

        public StatsBox()
        {
            InitializeComponent();

            statPairsAttack  = new StatPair[] { StatPairAttack0, StatPairAttack1, StatPairAttack2,
                                                StatPairAttack3, StatPairAttack4 };


            statPairsDefense = new StatPair[] { StatPairDefense0, StatPairDefense1, StatPairDefense2,
                                                StatPairDefense3, StatPairDefense4, StatPairDefense5,
                                                StatPairDefense6 };

            statPairsUtility = new StatPair[] { StatPairUtility0,  StatPairUtility1,  StatPairUtility2,
                                                StatPairUtility3,  StatPairUtility4,  StatPairUtility5,
                                                StatPairUtility6,  StatPairUtility7,  StatPairUtility8,
                                                StatPairUtility9,  StatPairUtility10, StatPairUtility11,
                                                StatPairUtility12, StatPairUtility13 };
        }

        private void PopulateStatMathList()
        {
            int numOfStats = (int)StatEnum.END_OF_LIST;

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

            ClearStats();
            ResetStats();
            CalculateStats(team);
            SortArrayForAlphabeticalOrder();
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
                if (crew != CrewEnum.END_OF_LIST)
                {
                    int crewID = (int)team.CrewMembers[crewIndex].CrewID;
                    AddCrewStatsToTotals(CrewList.CrewListing[crewID].CrewStats);
                }

                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    ImplantEnum implant = team.CrewMembers[crewIndex].ImplantIDs[implantIndex];

                    // Ignore NONE implants
                    if (implant != ImplantEnum.END_OF_LIST)
                    {
                        int implantID = (int)team.CrewMembers[crewIndex].ImplantIDs[implantIndex];
                        AddStatToTotals(ImplantList.ImplantListing[implantID].Stat);
                    }
                }
            }
        }

        private void SortArrayForAlphabeticalOrder()
        {
            StatCombination tempStat = StatMathList[(int)StatEnum.ENERGY_EFFICIENCY];

            Array.Sort(StatMathList, SortByNameAlphabetically);
        }

        private int SortByNameAlphabetically(StatCombination first, StatCombination second)
        {
            return first.Name.CompareTo(second.Name);
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
            int[] typeCount = { 0, 0, 0 };

            for (int index = 0; index < StatMathList.Length; index++)
            {
                StatCombination stat = StatMathList[index];

                int statCategoryInt = (int)stat.Category;

                if (stat.Value != 0)
                {
                    switch (stat.Category)
                    {
                        case StatCategory.ATTACK:
                        {
                            statPairsAttack[typeCount[statCategoryInt]].SetValues(stat);
                            break;
                        }
                        case StatCategory.DEFENSE:
                        {
                            statPairsDefense[typeCount[statCategoryInt]].SetValues(stat);
                            break;
                        }
                        case StatCategory.UTILITY:
                        {
                            statPairsUtility[typeCount[statCategoryInt]].SetValues(stat);
                            break;
                        }
                    }

                    typeCount[statCategoryInt]++;
                }
            }
        }

        private void ClearStats()
        {
            for (int index = 0; index < statPairsAttack.Length; index++)
            {
                statPairsAttack[index].ClearDownValues();
            }
            for (int index = 0; index < statPairsDefense.Length; index++)
            {
                statPairsDefense[index].ClearDownValues();
            }
            for (int index = 0; index < statPairsUtility.Length; index++)
            {
                statPairsUtility[index].ClearDownValues();
            }
        }

        public int GetStatMathListLength()
        {
            return StatMathList.Length;
        }
    }
}
