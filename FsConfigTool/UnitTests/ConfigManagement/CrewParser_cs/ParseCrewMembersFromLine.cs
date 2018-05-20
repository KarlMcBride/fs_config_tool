using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.ConfigManagement;
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

        /// <summary>
        /// Ensure that if a nonsensical line is parsed, that a default blank crew is returned
        /// </summary>
        [TestMethod]
        public void ParseDudRoster()
        {
            TeamConfig expected = new TeamConfig();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine("x");

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithClaraOnlyNoImplants()
        {
            TeamConfig expected = ParsedData.ClaraOnlyNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.CLARA_ONLY_NO_IMPLANTS);

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithThreeCrewNoCaptain()
        {
            TeamConfig expected = ParsedData.ThreeMembersNoCaptainNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.THREE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersNoImplants()
        {
            TeamConfig expected = ParsedData.BasicFiveMembersNoImplants();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersAllImplantsOrdered()
        {
            TeamConfig expected = ParsedData.FiveMembersFullImplantsOrdered();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_ALL_IMPLANTS_FULL_STRING);

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
        }

        [TestMethod]
        public void ParseRosterWithFiveMembersAllImplantsScattered()
        {
            TeamConfig expected = ParsedData.FiveMembersFullImplantsOrdered();
            TeamConfig actual = CrewParser.ParseCrewMembersFromLine(RawStringData.FIVE_MEMBERS_FULL_IMPLANTS_SCATTERED_FULL_STRING);

            TeamConfigComparer.VerifyCrewsMatch(expected, actual);
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

                TeamConfigComparer.VerifyCrewsMatch(expected, actual);
            }
        }
    }
}