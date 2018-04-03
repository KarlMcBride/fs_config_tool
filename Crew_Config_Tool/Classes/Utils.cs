using FS_Crew_Config_Tool.Content;
using System;
using System.Drawing;

namespace FS_Crew_Config_Tool.Classes
{
    public static class Utils
    {
        public static bool IsCrewMemberCaptain(CrewEnum id)
        {
            bool isCaptain = false;

            for (int crewID = (int)CrewEnum.CAESAR_MORGAN; crewID <= (int)CrewEnum.WHIM; crewID++)
            {
                if (id == (CrewEnum)crewID)
                {
                    isCaptain = true;
                    break;
                }
            }

            return isCaptain;
        }

        public static Bitmap GetCrewImageByIndex(int index)
        {
            string name = ((CrewEnum)index).ToString();

            Object rm = CrewResources.ResourceManager.GetObject(name);
            Bitmap myImage = (Bitmap)rm;
            return myImage;
        }

        public static Bitmap GetImplantImageByIndex(int index)
        {
            string name = ((ImplantEnum)index).ToString();

            Object rm = ImplantResources.ResourceManager.GetObject(name);
            Bitmap myImage = (Bitmap)rm;
            return myImage;
        }
    }
}
