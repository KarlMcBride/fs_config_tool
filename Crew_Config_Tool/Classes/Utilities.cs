using FS_Crew_Config_Tool.Content;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;

namespace FS_Crew_Config_Tool.Classes
{
    public static class Utilities
    {
        public const string FS_PLAYER_API = "https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?key=KEY&format=json&appid=310380";

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

        public static CrewEnum ConvertCrewStringToEnum(string crewName)
        {
            bool parseSuccessful = Enum.TryParse(crewName, out CrewEnum crewMember);

            if (!parseSuccessful)
            {
                crewMember = CrewEnum.NONE;
            }

            return crewMember;
        }

        public static ImplantEnum ConvertImplantStringToEnum(string implantName)
        {
            ImplantEnum implantEnum = ImplantEnum.NONE;

            for (int index = 0; index < (int)ImplantEnum.NONE; index++)
            {
                if (ImplantList.ImplantListing[index].Name.Equals(implantName))
                {
                    implantEnum = (ImplantEnum)index;
                    break;
                }
            }

            return implantEnum;
        }

        public static bool CheckIfFracSpaceIsRunning(string processName)
        {
            Process[] processlist = Process.GetProcesses();
            foreach (Process currentProcess in processlist)
            {
                if (currentProcess.ProcessName.Contains(processName))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Calls the Steam API to get the current player count and returns an int
        /// </summary>
        /// <returns>Player count in string format</returns>
        public static string GetOnlinePlayerCount()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(FS_PLAYER_API);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            string uriResponse = string.Empty;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            uriResponse = reader.ReadToEnd();

            stream.Dispose();

            string playerCount = "N/A";

            char[] separators = { ',', ':' };
            string[] parsed = uriResponse.Split(separators);

            playerCount = parsed[2];

            return playerCount;
        }
    }
}
