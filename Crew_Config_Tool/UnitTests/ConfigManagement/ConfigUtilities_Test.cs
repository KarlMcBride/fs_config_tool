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

            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                // Use the first member's enum, as it will be in the config we're checking against
                CrewEnum crew = teamConfig.CrewMembers[crewIndex].CrewID;

                int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(crew, teamConfig);

                Assert.AreEqual(crewIndex, result, "Expected a match for [" + crew.ToString() + "]");
            }
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstFullTeamNoMatch()
        {
            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.DICE_CAPLAN, teamConfig);

            Assert.AreEqual(ConfigUtilities.CREW_NOT_FOUND, result, "Expected no match");
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.DICE_CAPLAN, teamConfig);

            Assert.AreEqual(ConfigUtilities.CREW_NOT_FOUND, result, "Expected no match");
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstValidTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.AreEqual(ConfigUtilities.CREW_NOT_FOUND, result, "Expected no match");
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.AreEqual(ConfigUtilities.CREW_NOT_FOUND, result, "Expected no match");
        }
    }
}
