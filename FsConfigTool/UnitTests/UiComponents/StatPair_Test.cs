using System;
using FS_Crew_Config_Tool.Classes.Listings;
using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class StatPair_Test
    {
        [TestMethod]
        public void EnsureStatsAreEmptyUponInit()
        {
            string expected = string.Empty;

            StatPair pair = new StatPair();

            Assert.AreEqual(expected, pair.StatName, "Stat name is not empty");
            Assert.AreEqual(expected, pair.StatValue, "Stat value is not empty");
        }

        [TestMethod]
        public void SetPositiveStats()
        {
            string name = "Capture Rate";
            string value = "+5%";

            StatPair pair = new StatPair();
            pair.SetValues(new StatCombination(name, 5));

            Assert.AreEqual(name, pair.StatName, "Stat name is not set");
            Assert.AreEqual(value, pair.StatValue, "Stat value is not set");
        }

        [TestMethod]
        public void SetNegativeStats()
        {
            string name = "Broken Armour Damage Reduction";
            string value = "-2.5%";

            StatPair pair = new StatPair();
            pair.SetValues(new StatCombination(name, -2.5f));

            Assert.AreEqual(name, pair.StatName, "Stat name is not set");
            Assert.AreEqual(value.ToString(), pair.StatValue, "Stat value is not set");
        }

        [TestMethod]
        public void SetHitPointStats()
        {
            string name = "Hull Strength";
            string value = "+1000 HP";

            StatPair pair = new StatPair();
            pair.SetValues(new StatCombination(StatCategory.DEFENSE, StatEnum.HULL_STRENGTH, name, 1000));

            Assert.AreEqual(name, pair.StatName, "Stat name is not set");
            Assert.AreEqual(value.ToString(), pair.StatValue, "Stat value is not set");
        }

        [TestMethod]
        public void ClearDownStats()
        {
            StatPair pair = new StatPair();
            pair.SetValues(new StatCombination("Capture Rate", 5));

            pair.ClearDownValues();

            Assert.AreEqual("", pair.StatName, "Stat name is not cleared down");
            Assert.AreEqual("", pair.StatValue, "Stat value is not cleared down");
        }
    }
}
