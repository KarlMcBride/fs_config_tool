using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
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
            StatList.PopulateStatsList();
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        private RadioButton[] CreateRadioButtonArray(int numOfElements)
        {
            RadioButton[] array = new RadioButton[numOfElements];

            for (int index = 0; index < numOfElements; index++)
            {
                array[index] = new RadioButton();
            }

            return array;
        }

        [TestMethod]
        public void PopulateCrewListing()
        {
            RadioButton[] array = CreateRadioButtonArray((int)CrewRole.END_OF_LIST);

            for (int role = 0; role < (int)CrewRole.END_OF_LIST; role++)
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
            RadioButton[] array = CreateRadioButtonArray((int)StatCategory.END_OF_LIST);

            for (int role = 0; role < (int)StatCategory.END_OF_LIST; role++)
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
