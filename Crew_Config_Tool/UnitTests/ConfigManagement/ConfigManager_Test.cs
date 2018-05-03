using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement
{
    [TestClass]
    public class ConfigManager_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void GetNextSelectableItem_NoItemsAvailable()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = -1;
            int numOfItems = -1;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(selectedItem, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_NoItemSelected()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = -1;
            int numOfItems = 3;
            int expected = -1;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SingleItemSelected()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 0;
            int numOfItems = 1;
            int expected = -1;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_FirstItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 0;
            int numOfItems = 5;
            int expected = 0;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SecondItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 1;
            int numOfItems = 5;
            int expected = 1;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_LastItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 4;
            int numOfItems = 5;
            int expected = 3;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SecondLastItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 3;
            int numOfItems = 5;
            int expected = 3;

            int actualItem = manager.GetNextSelectableItem(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_EmptyCrewList()
        {
            ConfigManager manager = new ConfigManager();

            manager.AddSelectedMemberToSelectedCrew("asdf", 0);
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            ConfigManager.CrewLines crewLine = new ConfigManager.CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.ALA8AMA.ToString(), 0);

            Assert.IsTrue(result, "Failed to add crew member");
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_PopulatedCrewListSameRoleAlreadyPresent()
        {
            ConfigManager manager = new ConfigManager();

            ConfigManager.CrewLines crewLine = new ConfigManager.CrewLines();
            crewLine.Team = ParsedData.ThreeMembersNoCaptainNoImplants();

            manager.CrewData.Add(crewLine);

            string crewName = crewLine.Team.CrewMembers[0].CrewID.ToString();

            bool result = manager.AddSelectedMemberToSelectedCrew(crewName, 0);

            Assert.IsTrue(result, "Failed to add crew member");
        }

        [TestMethod]
        public void AddSelectedCaptainMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            ConfigManager.CrewLines crewLine = new ConfigManager.CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.CLARA_REISETTE.ToString(), 0);

            Assert.IsTrue(result, "Failed to add crew member");
        }

        [TestMethod]
        public void AddNonCrewMemberMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            ConfigManager.CrewLines crewLine = new ConfigManager.CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.NONE.ToString(), 0);

            Assert.IsFalse(result, "Added non-crew member to team");
        }
    }
}
