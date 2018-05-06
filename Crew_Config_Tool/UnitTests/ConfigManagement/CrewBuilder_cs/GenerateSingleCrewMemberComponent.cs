using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement.CrewBuilder_cs
{
    [TestClass]
    public class GenerateSingleCrewMemberComponent
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void OnlyImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = new TeamConfig();

            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.NONE;
            crewMember.ImplantIDs[0] = ImplantEnum.MANEUVERING;
            crewMember.ImplantIDs[1] = ImplantEnum.HULL_STRENGTH;
            crewMember.ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;

            string expected = "()";
            string actual = (string)crewBuilder.GenerateSingleCrewMemberComponent(crewMember);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void ClaraNoImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = new TeamConfig();

            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.CLARA_REISETTE;
            
            string expected = RawStringData.CLARA_ONLY_NO_IMPLANTS;
            string actual = (string)crewBuilder.GenerateSingleCrewMemberComponent(crewMember);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void ClaraOneImplant()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = new TeamConfig();

            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.CLARA_REISETTE;
            crewMember.ImplantIDs[0] = ImplantEnum.MANEUVERING;

            string expected = RawStringData.CLARA_ONLY_ONE_IMPLANT;
            string actual = (string)crewBuilder.GenerateSingleCrewMemberComponent(crewMember);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void ClaraTwoImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = new TeamConfig();

            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.CLARA_REISETTE;
            crewMember.ImplantIDs[0] = ImplantEnum.MANEUVERING;
            crewMember.ImplantIDs[1] = ImplantEnum.UTILITY_COOLDOWN;

            string expected = RawStringData.CLARA_ONLY_TWO_IMPLANTS;
            string actual = (string)crewBuilder.GenerateSingleCrewMemberComponent(crewMember);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }

        [TestMethod]
        public void ClaraThreeImplants()
        {
            CrewBuilder crewBuilder = new CrewBuilder();

            TeamConfig teamConfig = new TeamConfig();

            TeamConfig.EnumeratedCrewMember crewMember = new TeamConfig.EnumeratedCrewMember();

            crewMember.CrewID = CrewEnum.CLARA_REISETTE;
            crewMember.ImplantIDs[0] = ImplantEnum.MANEUVERING;
            crewMember.ImplantIDs[1] = ImplantEnum.HULL_STRENGTH;
            crewMember.ImplantIDs[2] = ImplantEnum.UTILITY_COOLDOWN;

            string expected = RawStringData.CLARA_ONLY_THREE_IMPLANTS;
            string actual = (string)crewBuilder.GenerateSingleCrewMemberComponent(crewMember);

            bool stringPresent = expected.Contains(actual);

            Assert.IsTrue(stringPresent, "Generated crew string [" + actual + "] is not within expected [" + expected);
        }
    }
}
