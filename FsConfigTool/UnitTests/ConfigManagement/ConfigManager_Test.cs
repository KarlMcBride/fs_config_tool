using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.TestData;

namespace UnitTests.ConfigManagement
{
    [TestClass]
    public class ConfigManager_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            StatList.PopulateStatsList();
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void GetNextSelectableItem_NoItemsAvailable()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = -1;
            int numOfItems = -1;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(selectedItem, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_NoItemSelected()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = -1;
            int numOfItems = 3;
            int expected = -1;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SingleItemSelected()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 0;
            int numOfItems = 1;
            int expected = -1;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_FirstItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 0;
            int numOfItems = 5;
            int expected = 0;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SecondItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 1;
            int numOfItems = 5;
            int expected = 1;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_LastItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 4;
            int numOfItems = 5;
            int expected = 3;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void GetNextSelectableItem_SecondLastItemInList()
        {
            ConfigManager manager = new ConfigManager();

            int selectedItem = 3;
            int numOfItems = 5;
            int expected = 3;

            int actualItem = manager.GetNextSelectableCrewInList(selectedItem, numOfItems);

            Assert.AreEqual(expected, actualItem);
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_EmptyCrewList()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.ALA8AMA.ToString(), 0);

            Assert.IsTrue(result, "Failed to add crew member");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.ALA8AMA.ToString(), 0);

            Assert.IsTrue(result, "Failed to add crew member");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void AddSelectedMemberToSelectedCrew_PopulatedCrewListSameRoleAlreadyPresent()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.ThreeMembersNoCaptainNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            string crewName = crewLine.Team.CrewMembers[0].CrewID.ToString();

            bool result = manager.AddSelectedMemberToSelectedCrew(crewName, 0);

            Assert.IsTrue(result, "Failed to add crew member");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void AddSelectedCaptainMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.CLARA_REISETTE.ToString(), 0);

            Assert.IsTrue(result, "Failed to add crew member");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void AddNonCrewMemberMemberToSelectedCrew_PopulatedCrewList()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.ClaraOnlyNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedMemberToSelectedCrew(CrewEnum.END_OF_LIST.ToString(), 0);

            Assert.IsFalse(result, "Added non-crew member to team");
            Assert.IsFalse(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be false");
        }

        /// <summary>
        /// Attempt to add an implant when no crew members are listed (i.e. blank team)
        /// </summary>
        [TestMethod]
        public void AddSelectedImplant_NoCrewPresent()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = new TeamConfig();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedImplantToNextFreeSlot(ImplantList.ImplantListing[(int)ImplantEnum.FIRE_RATE].Name, 0);

            Assert.IsTrue(result, "Didn't add implant to empty team");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        /// <summary>
        /// Attempt to add an implant to a valid crew
        /// </summary>
        [TestMethod]
        public void AddSelectedImplant_ValidCrewNoImplants()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.BasicFiveMembersNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            bool result = manager.AddSelectedImplantToNextFreeSlot(ImplantList.ImplantListing[(int)ImplantEnum.JUMP_PREP].Name, 0);

            Assert.IsTrue(result, "Failed to add implant");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        /// <summary>
        /// Attempt to add an implant to a valid crew twice. The second instance should cause the implant to
        /// go into the next crew member's slot
        /// </summary>
        [TestMethod]
        public void AddSelectedImplant_ValidCrewNoImplantsDuplicate()
        {
            ConfigManager manager = new ConfigManager();

            CrewLines crewLine = new CrewLines();
            crewLine.Team = ParsedData.BasicFiveMembersNoImplants();

            manager.DataLists.CrewData.Add(crewLine);

            manager.AddSelectedImplantToNextFreeSlot(ImplantList.ImplantListing[(int)ImplantEnum.JUMP_PREP].Name, 0);
            bool result = manager.AddSelectedImplantToNextFreeSlot(ImplantList.ImplantListing[(int)ImplantEnum.JUMP_PREP].Name, 0);

            Assert.AreEqual(ImplantEnum.JUMP_PREP, manager.DataLists.CrewData[0].Team.CrewMembers[0].ImplantIDs[0], "Crew 0 implant 0 not set");
            Assert.AreEqual(ImplantEnum.JUMP_PREP, manager.DataLists.CrewData[0].Team.CrewMembers[1].ImplantIDs[0], "Crew 1 implant 0 not set");
            Assert.AreEqual(ImplantEnum.END_OF_LIST, manager.DataLists.CrewData[0].Team.CrewMembers[0].ImplantIDs[1], "Crew 0 implant 1 set");

            Assert.IsTrue(result, "Expected to add implant");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        /// <summary>
        /// Adds a new crew to the list, checking list size and flag save state.
        /// Contains parameters to allow reuse by RemoveCrewFromList
        /// </summary>
        [TestMethod]
        public void AddNewCrewToList()
        {
            ConfigManager manager = new ConfigManager();

            int startingSize = manager.DataLists.CrewData.Count;

            string newCrewName = "Test Crew Alpha";
            manager.AddNewCrew(newCrewName);

            int endSize = manager.DataLists.CrewData.Count;

            Assert.AreEqual(startingSize + 1, endSize, "Expected size to increase by 1");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void RemoveCrewFromList()
        {
            ConfigManager manager = new ConfigManager();

            int startingSize = manager.DataLists.CrewData.Count;

            manager.AddNewCrew("Test Crew Beta");
            manager.DeleteSelectedCrewFromList(0);

            int endSize = manager.DataLists.CrewData.Count;

            Assert.AreEqual(startingSize, endSize, "Expected size to remain constant. Start [" + startingSize + "], end [" + endSize + "]");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }

        [TestMethod]
        public void RenameCrewInList()
        {
            ConfigManager manager = new ConfigManager();

            int indexZero = 0;
            string startingName = "Test Crew Charlie";
            string newName = "Test Crew Charon";

            manager.AddNewCrew(startingName);

            Assert.AreEqual(startingName, manager.DataLists.CrewData[indexZero].CrewName, "Starting crew name did not match");

            manager.RenameCrew(indexZero, newName);

            Assert.AreEqual(newName, manager.DataLists.CrewData[indexZero].CrewName, "New crew name did not match");
            Assert.IsTrue(manager.UnsavedChangesPresent, "Expected UnsavedChangesPresent flag to be true");
        }
    }
}
