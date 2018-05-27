using FS_Config_Tool;
using FS_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

namespace UnitTests.ConfigManagement
{
    [TestClass]
    public class DataTypes_Test : UnitTestCore
    {
        [TestMethod]
        public void ParseEmptyLine()
        {
            string expected = string.Empty;

            CrewLines line = new CrewLines();
            line.RawLine = expected;
            line.ParseLine();

            Assert.AreEqual(expected, line.CrewName, "Parsed crewname isn't empty");
        }

        [TestMethod]
        public void ParseNoCrewLine()
        {
            string expected = "The Opportunists";

            CrewLines line = new CrewLines();
            line.RawLine = RawStringData.NO_MEMBERS_FULL_STRING;
            line.ParseLine();

            Assert.AreEqual(expected, line.CrewName, "Parsed crewname doesn't match");
        }

        [TestMethod]
        public void ParseFullyPopulatedLine()
        {
            string expected = "Paladin - Max Heal";

            CrewLines line = new CrewLines();
            line.RawLine = RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING;
            line.ParseLine();

            Assert.AreEqual(expected, line.CrewName, "Parsed crewname doesn't match");
        }

        [TestMethod]
        public void ParseSpacedLine()
        {
            string expected = "Undefined";

            CrewLines line = new CrewLines();
            line.RawLine = RawStringData.NO_MEMBERS_FULL_STRING_SPACED;
            line.ParseLine();

            Assert.AreEqual(expected, line.CrewName, "Parsed crewname isn't empty [" + line.CrewName + "]");
        }

        [TestMethod]
        public void BuildLine()
        {
            string expected = RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING;

            CrewLines line = new CrewLines();
            line.RawLine = expected;
            line.ParseLine();

            string actual = line.BuildLine();

            Assert.AreEqual(expected, actual, "Built crew line does not match");
        }
    }
}
