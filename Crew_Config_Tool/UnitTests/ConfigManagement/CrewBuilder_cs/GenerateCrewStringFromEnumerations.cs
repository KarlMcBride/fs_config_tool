using System;
using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement.CrewBuilder_cs
{
    [TestClass]
    public class GenerateCrewStringFromEnumerations
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void ClaraOnlyNoImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = ParsedData.ClaraOnlyNoImplants();

            string expected = RawStringData.BUILDER_CLARA_ONLY_FULL_TEAM;
            string actual = (string)crewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void BasicFiveMembersNoImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            string expected = RawStringData.FIVE_MEMBERS_NO_IMPLANTS;
            string actual = (string)crewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void FullTeamWithImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            string expected = RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING;
            string actual = (string)crewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }
    }
}
