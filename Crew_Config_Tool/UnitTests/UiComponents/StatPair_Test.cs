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
        public void SetStats()
        {
            string name = "Capture Rate";
            float value = 5;

            StatPair pair = new StatPair();
            pair.SetValues(new StatCombination("Capture Rate", 5));

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
