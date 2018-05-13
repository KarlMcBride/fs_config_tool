using FS_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Listings
{
    [TestClass]
    public class Stats_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            StatList.PopulateStatsList();
        }

        [TestMethod]
        public void VerifyStatsCountsMatch()
        {
            int enum_expected = (int)StatEnum.END_OF_LIST;

            int actual = StatList.StatsListing.Count;

            Assert.AreEqual(enum_expected, actual);
        }

        [TestMethod]
        public void VerifyStatsListOrder()
        {
            for (int index = 0; index < (int)StatEnum.END_OF_LIST; index++)
            {
                StatEnum expected = (StatEnum)index;

                StatEnum actual = StatList.StatsListing[index].Type;

                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void VerifyTwoParameterConstructor()
        {
            string name = "Capture Rate";
            float value = 5;

            StatCombination stat = new StatCombination(name, value);

            Assert.AreEqual(name, stat.Name, "Stat name is not set");
            Assert.AreEqual(value, stat.Value, "Stat value is not set");
        }

        [TestMethod]
        public void GenerateFormattedStringForDisplay_Positive()
        {
            string expected = "+0.4%";

            StatCombination stat = new StatCombination(StatCategory.ATTACK, StatEnum.ATTACK_DAMAGE, "Attack Damage", 0.4f);
            string actual = stat.GenerateFormattedStringForDisplay();

            Assert.AreEqual(expected, actual, "Positive percentage formatted string did not match");
        }

        [TestMethod]
        public void GenerateFormattedStringForDisplay_Negative()
        {
            string expected = "-5%";

            StatCombination stat = new StatCombination(StatCategory.UTILITY, StatEnum.JUMP_PREP, "Jump Prep", -5f);
            string actual = stat.GenerateFormattedStringForDisplay();

            Assert.AreEqual(expected, actual, "Negative percentage formatted string did not match");
        }

        [TestMethod]
        public void GenerateFormattedStringForDisplay_HullStrength()
        {
            string expected = "+200 HP";

            StatCombination stat = new StatCombination(StatCategory.DEFENSE, StatEnum.HULL_STRENGTH, "Hull Strength", 200);
            string actual = stat.GenerateFormattedStringForDisplay();

            Assert.AreEqual(expected, actual, "HP formatted string did not match");
        }
    }
}
