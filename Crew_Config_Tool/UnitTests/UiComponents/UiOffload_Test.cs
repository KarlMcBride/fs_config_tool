using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class UiOffload_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        private CheckBox[] CreateCheckBoxArray(int numOfElements)
        {
            CheckBox[] array = new CheckBox[numOfElements];

            for (int index = 0; index < numOfElements; index++)
            {
                array[index] = new CheckBox();
            }

            return array;
        }

        [TestMethod]
        public void PopulateCrewListing()
        {
            CheckBox[] array = CreateCheckBoxArray((int)CrewRole.UTILITY + 1);

            for (int role = 0; role <= (int)CrewRole.UTILITY; role++)
            {
                array[role].Checked = true;

                UiOffload uiOffload = new UiOffload();
                ImageList imageList = new ImageList();
                ListView listView = new ListView();

                uiOffload.PopulateCrewListing(array, ref listView);

                array[role].Checked = false;

                for (int index = 0; index < listView.Items.Count; index++)
                {
                    Assert.IsNotNull(listView.Items[index].ImageIndex, "Image index [" + index + "] is null");
                }
            }
        }

        [TestMethod]
        public void PopulateImplantListing()
        {
            CheckBox[] array = CreateCheckBoxArray((int)ImplantType.UTILITY + 1);

            for (int role = 0; role <= (int)ImplantType.UTILITY; role++)
            {
                array[role].Checked = true;

                UiOffload uiOffload = new UiOffload();
                ImageList imageList = new ImageList();
                ListView listView = new ListView();

                uiOffload.PopulateImplantListing(array, ref listView);

                array[role].Checked = false;

                for (int index = 0; index < listView.Items.Count; index++)
                {
                    Assert.IsNotNull(listView.Items[index].ImageIndex, "Image index [" + index + "] is null");
                }
            }
        }
    }
}
