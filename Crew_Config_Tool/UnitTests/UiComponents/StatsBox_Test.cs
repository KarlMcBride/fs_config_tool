using FS_Crew_Config_Tool.Classes.Listings;
using FS_Crew_Config_Tool.UiComponents;
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
        }

        [TestMethod]
        public void PopulateStatMathList()
        {
            StatsBox statsBox = new StatsBox();

            statsBox.CallHiddenMethod("PopulateStatMathList");

            int actualSize = statsBox.GetStatMathListLength();
            int expectedSize = (int)StatType.ENERGY_EFFICIENCY + 1;

            Assert.AreEqual(expectedSize, actualSize, "Size of StatMathList is not correct");
        }
    }
}
