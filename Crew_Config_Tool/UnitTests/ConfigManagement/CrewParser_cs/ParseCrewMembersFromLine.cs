using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

namespace UnitTests.ConfigManagement.CrewParser_cs
{
    [TestClass]
    public class ParseCrewMembersFromLine
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        private void VerifyCrewsMatch(TeamConfig expected, TeamConfig actual)
        {
            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                Assert.AreEqual(expected.CrewMembers[crewIndex].CrewID, actual.CrewMembers[crewIndex].CrewID);

                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    Assert.AreEqual(expected.CrewMembers[crewIndex].ImplantIDs[implantIndex], actual.CrewMembers[crewIndex].ImplantIDs[implantIndex]);
                }
            }
        }

        /// <summary>
        /// Ensure that if a nonsensical line is parsed, that a default blank crew is returned
        /// </summary>
        [TestMethod]
        public void ParseDudRoster()
        {
            TeamConfig expected = new TeamConfig();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine("x");

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithClaraOnlyNoImplants()
        {
            TeamConfig expected = ParsedData.ClaraOnlyNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.CLARA_ONLY_NO_IMPLANTS);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithThreeCrewNoCaptain()
        {
            TeamConfig expected = ParsedData.ThreeMembersNoCaptainNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.THREE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersNoImplants()
        {
            TeamConfig expected = ParsedData.BasicFiveMembersNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersAllImplantsOrdered()
        {
            TeamConfig expected = ParsedData.FiveMembersFullImplantsOrdered();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersAllImplantsScattered()
        {
            TeamConfig expected = ParsedData.FiveMembersFullImplantsOrdered();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_FULL_IMPLANTS_SCATTERED_FULL_STRING);

            VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithDynamicCrewInputNoImplants()
        {
            for (int id = 0; id < (int)CrewEnum.END_OF_LIST; id++)
            {
                string customLine = RawStringData.SINGLE_MEMBER_TEMPLATE[0]
                                        + CrewList.CrewListing[id].Code
                                        + RawStringData.SINGLE_MEMBER_TEMPLATE[1];

                TeamConfig expected = new TeamConfig();
                expected.CrewMembers[0].CrewID = (CrewEnum)id;

                TeamConfig actual = CrewParser.ParseCrewMembersFromLine(customLine);

                VerifyCrewsMatch(expected, actual);
            }
        }
    }
}