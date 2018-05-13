using System;
using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

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
            TeamConfig teamConfig = ParsedData.ClaraOnlyNoImplants();

            string expected = RawStringData.BUILDER_CLARA_ONLY_FULL_TEAM;
            string actual = CrewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void BasicFiveMembersNoImplants()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            // HACK: Padding raw data locally - investigate why this is necessary
            string expected = "(" + RawStringData.FIVE_MEMBERS_NO_IMPLANTS + ")";
            string actual = CrewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void FullTeamWithImplants()
        {
            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            string expected = RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING;
            string actual = CrewBuilder.GenerateCrewStringFromEnumerations(teamConfig);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }
    }
}
