using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.Listings;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

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

        /// <summary>
        /// Ensure that all values are cleared down when populated
        /// </summary>
        [TestMethod]
        public void ResetStats()
        {
            StatsBox statsBox = new StatsBox();

            // Implants cover all stats except energy efficiency, so use a comms officer to move it off zero

            TeamConfig commsCrew = new TeamConfig();
            commsCrew.CrewMembers[0].CrewID = CrewEnum.PROTAGONIST;
            statsBox.CallHiddenMethod("CalculateStats", commsCrew);

            for (int implantIndex = 0; implantIndex < (int)ImplantEnum.END_OF_LIST; implantIndex++)
            {
                TeamConfig implantConfig = new TeamConfig();
                implantConfig.CrewMembers[0].ImplantIDs[0] = (ImplantEnum)implantIndex;

                statsBox.CallHiddenMethod("CalculateStats", implantConfig);
            }

            statsBox.CallHiddenMethod("ResetStats");

            for (int index = 0; index < statsBox.StatMathList.Length; index++)
            {
                Assert.AreEqual(0, statsBox.StatMathList[index].Value, "Statistic is non-zero");
            }
        }
    }
}
