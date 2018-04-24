using System;
using FS_Crew_Config_Tool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ConfigManagement
{
    [TestClass]
    public class ConfigManager_Test
    {
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
    }
}
