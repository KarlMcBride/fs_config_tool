using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.Listings;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class StatsBox_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            StatList.PopulateStatsList();
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void AssignAllCrewMembersToEachSlot()
        {
            StatsBox statsBox = new StatsBox();
            statsBox.PopulateStatMathList();

            for (int crewIndex = 0; crewIndex < (int) CrewEnum.END_OF_LIST; crewIndex++)
            {
                CrewRole role = CrewList.CrewListing[crewIndex].Role;

                int expectedNonZeros = (role == CrewRole.CAPTAIN) ? 3 : 2;

                for (int slotIndex = 0; slotIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; slotIndex++)
                {
                    TeamConfig crew = new TeamConfig();
                    crew.CrewMembers[slotIndex].CrewID = (CrewEnum)crewIndex;

                    statsBox.CallHiddenMethod("CalculateStats", crew);

                    int nonZerosFound = 0;

                    for (int index = 0; index < statsBox.StatMathList.Length; index++)
                    {
                        // Check 'index' and crewIndex will match when we're setting that value, so expect non-zero
                        if (statsBox.StatMathList[index].Value != 0)
                        {
                            nonZerosFound++;
                        }
                    }

                    statsBox.CallHiddenMethod("ResetStats");

                    string crewEnumString = ((CrewEnum)crewIndex).ToString();

                    Assert.AreEqual(expectedNonZeros, nonZerosFound, "Non-zeros for [" 
                                     + crewEnumString + "], slotIndex [" + slotIndex + "]");
                }
            }
        }

        [TestMethod]
        public void AssignAllImplantsToEachSlot()
        {
            StatsBox statsBox = new StatsBox();
            statsBox.PopulateStatMathList();

            for (int implantIndex = 0; implantIndex < (int)ImplantEnum.END_OF_LIST; implantIndex++)
            {
                for (int crewSlotIndex = 0; crewSlotIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewSlotIndex++)
                {
                    for (int implantSlotIndex = 0; implantSlotIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantSlotIndex++)
                    {
                        TeamConfig crew = new TeamConfig();
                        crew.CrewMembers[crewSlotIndex].ImplantIDs[implantSlotIndex] = (ImplantEnum)implantIndex;

                        statsBox.CallHiddenMethod("CalculateStats", crew);

                        int nonZerosFound = 0;

                        for (int index = 0; index < statsBox.StatMathList.Length; index++)
                        {
                            // Check 'index' and crewIndex will match when we're setting that value, so expect non-zero
                            if (statsBox.StatMathList[index].Value != 0)
                            {
                                nonZerosFound++;
                            }
                        }

                        statsBox.CallHiddenMethod("ResetStats");

                        string implantEnumString = ((ImplantEnum)implantIndex).ToString();

                        Assert.AreEqual(1, nonZerosFound, "Unexpected non-zeroes (" + nonZerosFound + ") for implant [" 
                                         + implantEnumString + "], slotIndex [" + implantSlotIndex + "]");
                    }
                }
            }
        }

        /// <summary>
        /// Ensure that all values are non-zeroed cleared down when populated
        /// </summary>
        [TestMethod]
        public void AssignAndResetAllStats()
        {
            StatsBox statsBox = new StatsBox();
            statsBox.PopulateStatMathList();

            // Implants cover all stats except energy efficiency, so use a utility officer to move it off zero

            TeamConfig commsCrew = new TeamConfig();
            commsCrew.CrewMembers[0].CrewID = CrewEnum.ZHANG_TAO;
            statsBox.CallHiddenMethod("CalculateStats", commsCrew);

            for (int implantIndex = 0; implantIndex < (int)ImplantEnum.END_OF_LIST; implantIndex++)
            {
                TeamConfig implantConfig = new TeamConfig();
                implantConfig.CrewMembers[0].ImplantIDs[0] = (ImplantEnum)implantIndex;

                statsBox.CallHiddenMethod("CalculateStats", implantConfig);
            }

            for (int index = 0; index < statsBox.StatMathList.Length; index++)
            {
                Assert.AreNotEqual(0, statsBox.StatMathList[index].Value, "Statistic [" + index + "] is zero");
            }

            statsBox.CallHiddenMethod("ResetStats");

            for (int index = 0; index < statsBox.StatMathList.Length; index++)
            {
                Assert.AreEqual(0, statsBox.StatMathList[index].Value, "Statistic [" + index + "] is non-zero");
            }
        }
    }
}
