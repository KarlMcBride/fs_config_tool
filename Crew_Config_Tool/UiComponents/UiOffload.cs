using FS_Crew_Config_Tool.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace FS_Crew_Config_Tool.UiComponents
{
    /// <summary>
    /// Class specifically designed to contain UI logic, to declutter and allow unit testing
    /// </summary>
    public class UiOffload
    {
        public void PopulateCrewListing(CheckBox[] crewFilterArray, ref ListView listView)
        {
            listView.Clear();

            ImageList imageList = new ImageList();
            imageList.ColorDepth = ColorDepth.Depth16Bit;

            int crew_w = 100;
            int crew_h = 177;
            int buffer = 5;

            listView.TileSize = new Size(crew_w + buffer, crew_h + buffer);
            imageList.ImageSize = new Size(crew_w, crew_h);

            listView.LargeImageList = imageList;

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
    }
}
