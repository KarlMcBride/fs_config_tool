using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class ShipSelector_Test : UnitTestCore
    {
        private ShipArgs localShipArgs;

        private void ShipSelectionReceiver(object sender, ShipArgs e)
        {
            localShipArgs = e;
        }

        [TestMethod]
        public void ButtonSelectAll_Check()
        {
            ShipSelector selector = new ShipSelector();

            Button allButton = new Button();
            allButton.Name = "ButtonSelectAll"; // Name of button in ShipSelector.cs

            selector.CallHiddenMethod("ButtonSelectAllOrNone_Click", allButton, null);

            int sizeOfArray = selector.CheckBoxArray.Length;

            for (int index = 0; index < sizeOfArray; index++)
            {
                Assert.IsTrue(selector.CheckBoxArray[index].Checked, "Index [" + index + "] is not selected");
            }
        }

        [TestMethod]
        public void ButtonSelectNone_Check()
        {
            ShipSelector selector = new ShipSelector();

            Button allButton = new Button();
            allButton.Name = "ButtonSelectNone"; // Name of button in ShipSelector.cs

            selector.CallHiddenMethod("ButtonSelectAllOrNone_Click", allButton, null);

            int sizeOfArray = selector.CheckBoxArray.Length;

            for (int index = 0; index < sizeOfArray; index++)
            {
                Assert.IsFalse(selector.CheckBoxArray[index].Checked, "Index [" + index + "] is not selected");
            }
        }

        [TestMethod]
        public void ButtonGenerate_ArgsCheck()
        {
            ShipSelector selector = new ShipSelector();

            Button allButton = new Button();
            allButton.Name = "ButtonSelectAll"; // Name of button in ShipSelector.cs
            // Select all checkboxes - we should expect all arg checkboxes to be true later on
            selector.CallHiddenMethod("ButtonSelectAllOrNone_Click", allButton, null);

            // Hook up a listener
            selector.GenerateButtonClicked += ShipSelectionReceiver;

            selector.CallHiddenMethod("ButtonGenerate_Click", null, null);

            for (int index = 0; index < localShipArgs.ArrayLength; index++)
            {
                Assert.IsTrue(localShipArgs.ShipSelectionArray[index], "Index [" + index + "] is not selected");
            }
        }

        [TestMethod]
        public void ButtonGenerate_NoListenerAttached()
        {
            ShipSelector selector = new ShipSelector();

            Button allButton = new Button();

            selector.CallHiddenMethod("ButtonGenerate_Click", null, null);
        }
    }
}
