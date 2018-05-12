using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

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
        public void CheckEndOfListCrewMemberAgainstValidTeam()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.END_OF_LIST, teamConfig);

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
        public void CheckEndOFListCrewMemberAgainstEmptyTeam()
        {
            TeamConfig teamConfig = new TeamConfig();

            int result = ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum.END_OF_LIST, teamConfig);

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
        public void CountNumberOfImplantsInFullMemberTeam_NoImplants()
        {
            TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

            int result = ConfigUtilities.CountNumberOfImplantsInTeam(teamConfig);

            Assert.AreEqual(0, result, "Expected to have 0 implants");
        }

        [TestMethod]
        public void CountNumberOfImplantsInFullMemberTeam_FullImplants()
        {
            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            int result = ConfigUtilities.CountNumberOfImplantsInTeam(teamConfig);

            Assert.AreEqual(15, result, "Expected to have 15 implants");
        }

        [TestMethod]
        public void CountNumberOfImplants_BasicCrewMember()
        {
            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.BLADE;

            int result = ConfigUtilities.CountNumberOfImplantsInCrewMember(crewMember);

            Assert.AreEqual(0, result, "Expected to have 0 implants");
        }

        [TestMethod]
        public void CountNumberOfImplants_CrewPlusOneImplant()
        {
            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.BLADE;
            crewMember.ImplantIDs[0] = ImplantEnum.ARMOUR_STRENGTH;

            int result = ConfigUtilities.CountNumberOfImplantsInCrewMember(crewMember);

            Assert.AreEqual(1, result, "Expected to have 1 implant");
        }

        [TestMethod]
        public void CountNumberOfImplants_CrewPlusTwoImplants()
        {
            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.BLADE;
            crewMember.ImplantIDs[0] = ImplantEnum.ARMOUR_STRENGTH;
            crewMember.ImplantIDs[0] = ImplantEnum.CAPTURE_RATE;

            int result = ConfigUtilities.CountNumberOfImplantsInCrewMember(crewMember);

            Assert.AreEqual(1, result, "Expected to have 2 implants");
        }

        [TestMethod]
        public void CountNumberOfImplants_CrewPlusThreeImplants()
        {
            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.BLADE;
            crewMember.ImplantIDs[0] = ImplantEnum.ARMOUR_STRENGTH;
            crewMember.ImplantIDs[0] = ImplantEnum.CAPTURE_RATE;
            crewMember.ImplantIDs[0] = ImplantEnum.REPAIR_EFFICIENCY;

            int result = ConfigUtilities.CountNumberOfImplantsInCrewMember(crewMember);

            Assert.AreEqual(1, result, "Expected to have 3 implants");
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

        [TestMethod]
        public void FindFirstFreeImplantSlot_EmptyCrew()
        {
            TeamConfig teamConfig = new TeamConfig();

            ConfigUtilities.CrewImplantIndexStruct expected = new ConfigUtilities.CrewImplantIndexStruct(true, 0, 0);

            ConfigUtilities.CrewImplantIndexStruct actual = ConfigUtilities.FindFirstFreeImplantSlotWithoutDuplication(teamConfig, ImplantEnum.FIRE_RATE);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindFirstFreeImplantSlot_FullCrew()
        {
            TeamConfig teamConfig = ParsedData.FiveMembersFullImplantsOrdered();

            ConfigUtilities.CrewImplantIndexStruct expected = new ConfigUtilities.CrewImplantIndexStruct(false);

            ConfigUtilities.CrewImplantIndexStruct actual = ConfigUtilities.FindFirstFreeImplantSlotWithoutDuplication(teamConfig, ImplantEnum.FIRE_RATE);

            Assert.AreEqual(expected, actual, "Return struct did not match: " +
                        "expected: [" + expected.EmptySlotFound + ", " + expected.CrewIndex + ", " + expected.ImplantIndex + "], " +
                        "actual:   [" + actual.EmptySlotFound + ", " + actual.CrewIndex + ", " + actual.ImplantIndex + "]");
        }

        [TestMethod]
        public void FindFirstFreeImplantSlot_FullCrewWithSingleImplant()
        {
            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    TeamConfig teamConfig = ParsedData.BasicFiveMembersNoImplants();

                    teamConfig.CrewMembers[crewIndex].ImplantIDs[implantIndex] = ImplantEnum.ENERGY_REGEN;

                    int validImplantIndex = 0;

                    // If the crewmember has a single implant, it should default to index zero of the first crewmember, unless zero is occupied
                    if (crewIndex == 0 && implantIndex == 0)
                    {
                        validImplantIndex = 1;
                    }

                    ConfigUtilities.CrewImplantIndexStruct expected = new ConfigUtilities.CrewImplantIndexStruct(true, 0, validImplantIndex);

                    ConfigUtilities.CrewImplantIndexStruct actual = ConfigUtilities.FindFirstFreeImplantSlotWithoutDuplication(teamConfig, ImplantEnum.FIRE_RATE);

                    Assert.AreEqual(expected, actual, "Return struct did not match: " +
                        "expected: [" + expected.EmptySlotFound + ", " + expected.CrewIndex + ", " + expected.ImplantIndex + "], " +
                        "actual:   ["+ actual.EmptySlotFound + ", " + actual.CrewIndex + ", " + actual.ImplantIndex + "]");
                }
            }
        }

        [TestMethod]
        public void GetStartOfRawCrewString()
        {
            string expected = RawStringData.NO_MEMBERS_PARTIAL_STRING;

            string actual = ConfigUtilities.GetStartOfRawCrewString(RawStringData.NO_MEMBERS_FULL_STRING);

            Assert.AreEqual(expected, actual, "Partial crew string differs");
        }
    }
}
