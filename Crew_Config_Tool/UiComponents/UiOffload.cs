using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    /// <summary>
    /// Class specifically designed to contain UI logic, to declutter and allow unit testing
    /// </summary>
    public class UiOffload
    {
        public void PopulateCrewListing(RadioButton[] crewFilterArray, ref ListView listView)
        {
            listView.Clear();

            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth16Bit;

            int crew_w = 100;
            int crew_h = 177;
            int buffer = 5;

            listView.TileSize = new Size(crew_w + buffer, crew_h + buffer);
            imageList.ImageSize = new Size(crew_w, crew_h);

            int index = 0;

            for (int id = 0; id < (int)CrewEnum.NONE; id++)
            {
                CrewRole idRole = CrewList.CrewListing[id].Role;

                if (crewFilterArray[(int)idRole].Checked)
                {
                    string name = ((CrewEnum)id).ToString();

                    imageList.Images.Add(name, Utilities.GetCrewImageByIndex(id));
                    listView.Items.Add(name, index);

                    index++;
                }
            }

            listView.LargeImageList = imageList;
        }

        public void PopulateImplantListing(RadioButton[] implantFilterArray, ref ListView listView)
        {
            listView.Clear();

            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth16Bit;

            int implant_w = 50;
            int implant_h = 50;
            int buffer = 5;

            listView.TileSize = new Size(implant_w + buffer, implant_h + buffer);
            imageList.ImageSize = new Size(implant_w, implant_h);

            StatCategory implantCategory = StatCategory.END_OF_LIST;
            for (int radioIndex = 0; radioIndex < implantFilterArray.Length; radioIndex++)
            {
                if (implantFilterArray[radioIndex].Checked)
                {
                    implantCategory = (StatCategory)radioIndex;
                    break;
                }
            }

            int index = 0;
            // Loop through all implants
            for (int id = 0; id < (int)ImplantEnum.NONE; id++)
            {
                if (implantCategory == ImplantList.ImplantListing[id].Category)
                {
                    string name = ImplantList.ImplantListing[id].Name;

                    imageList.Images.Add(name, Utilities.GetImplantImageByIndex(id));
                    listView.Items.Add(name, index);

                    index++;
                }
            }

            listView.LargeImageList = imageList;
        }
    }
}
