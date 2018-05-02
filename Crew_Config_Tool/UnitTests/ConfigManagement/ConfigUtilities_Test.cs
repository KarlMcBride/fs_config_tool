using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement
{
    [TestClass]
    public class ConfigUtilities_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstFullTeamMatch()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            // Use the first member's enum, as it will be in the config we're checking against
            CrewEnum crew = teamConfig.CrewMembers[0].CrewID;

            bool result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(crew, teamConfig);

            Assert.IsTrue(result, "Expected a match for [" + crew.ToString() + "]");
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstFullTeamNoMatch()
        {
            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            bool result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.DICE_CAPLAN, teamConfig);

            Assert.IsFalse(result, "Expected no match");
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            bool result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.DICE_CAPLAN, teamConfig);

            Assert.IsFalse(result, "Expected no match");
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstValidTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            bool result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.IsFalse(result, "Expected no match");
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            bool result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.IsFalse(result, "Expected no match");
        }
    }
}
