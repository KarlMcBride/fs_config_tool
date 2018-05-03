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

            Assert.AreEqual(ConfigUtilities.OUT_OF_BOUNDS, result, "Expected no match");
        }

        [TestMethod]
        public void CheckValidCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.DICE_CAPLAN, teamConfig);

            Assert.AreEqual(ConfigUtilities.OUT_OF_BOUNDS, result, "Expected no match");
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstValidTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.AreEqual(ConfigUtilities.OUT_OF_BOUNDS, result, "Expected no match");
        }

        [TestMethod]
        public void CheckPresentCrewMemberAgainstFullTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            for(int index = 0; index < 5; index++)
            {
                CrewEnum crewId = teamConfig.CrewMembers[index].CrewID;

                int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(crewId, teamConfig);

                Assert.AreEqual(index, result, "Expected a match");

            }
        }

        [TestMethod]
        public void CheckNoneCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.NONE, teamConfig);

            Assert.AreEqual(ConfigUtilities.OUT_OF_BOUNDS, result, "Expected no match");
        }

        [TestMethod]
        public void CountNumberOfCrewInEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CountNumberOfCrewInTeam(teamConfig);

            Assert.AreEqual(0, result, "Expected to have 0 crew members");
        }

        [TestMethod]
        public void CountNumberOfCrewInSingleMemberTeam()
        {
            TeamConfig teamConfig = ParsedData.ClaraOnlyNoImplants();

            int result = ConfigUtilities.CountNumberOfCrewInTeam(teamConfig);

            Assert.AreEqual(1, result, "Expected to have 1 crew member");
        }

        [TestMethod]
        public void CountNumberOfCrewInFullMemberTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.CountNumberOfCrewInTeam(teamConfig);

            Assert.AreEqual(5, result, "Expected to have 5 crew members");
        }

        [TestMethod]
        public void FindFirstFreeSlotForNonCaptain_EmptyCrew()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.FindFirstFreeSlotForNonCaptain(teamConfig);

            Assert.AreEqual(0, result, "Expected index 0 to be the next free slot");
        }

        [TestMethod]
        public void FindFirstFreeSlotForNonCaptain_ThreeMemberCrew()
        {
            TeamConfig teamConfig = ParsedData.ThreeMembersNoCaptainNoImplants();

            int result = ConfigUtilities.FindFirstFreeSlotForNonCaptain(teamConfig);

            Assert.AreEqual(1, result, "Expected index 1 to be the next free slot");
        }

        [TestMethod]
        public void FindFirstFreeSlotForNonCaptain_FullCrew()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.FindFirstFreeSlotForNonCaptain(teamConfig);

            Assert.AreEqual(ConfigUtilities.OUT_OF_BOUNDS, result, "Expected index ["
                                + ConfigUtilities.OUT_OF_BOUNDS + "] to be returned");
        }
    }
}
