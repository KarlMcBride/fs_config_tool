using FS_Config_Tool.Content;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;

namespace FS_Config_Tool.Classes
{
    public static class Utilities
    {
        public const string FS_PLAYER_API = "https://api.steampowered.com/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?key=KEY&format=json&appid=310380";
        public const string DOCS_SW_VERSION = "https://docs.google.com/document/d/1Nr_iR2cXICoyYjgbHTPc3Cb48BdVaV9PSVZnBJRcMP0/edit?usp=sharing";

        private const string VERSION_START = "LatestVerStart";
        private const string VERSION_END = "LatestVerEnd";
        private const string LINK_START = "LinkStart";
        private const string LINK_END = "LinkEnd";
        private const string NOTES_START = "NotesStart:";
        private const string NOTES_END = ":NotesEnd";

        public static bool   UpdateAvailable { get; private set; }
        public static string LatestVersion   { get; private set; }
        public static string LatestLink      { get; private set; }
        public static string LatestNotes     { get; private set; }

        private static bool apiErrorShown = false;

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
                crewMember = CrewEnum.END_OF_LIST;
            }

            return crewMember;
        }

        public static ImplantEnum ConvertImplantStringToEnum(string implantName)
        {
            ImplantEnum implantEnum = ImplantEnum.END_OF_LIST;

            for (int index = 0; index < (int)ImplantEnum.END_OF_LIST; index++)
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
            string uriResponse = GetWebRequest(FS_PLAYER_API);

            string playerCount = "N/A";

            char[] separators = { ',', ':' };
            string[] parsed = uriResponse.Split(separators);

            playerCount = parsed[2];

            return playerCount;
        }

        public static void CheckLatestSoftwareVersion()
        {
            string uriResponse = GetWebRequest(DOCS_SW_VERSION);

            LatestVersion = ParseOutInfo(uriResponse, VERSION_START, VERSION_END);
            LatestLink = ParseOutInfo(uriResponse, LINK_START, LINK_END);
            LatestNotes = ParseOutInfo(uriResponse, NOTES_START, NOTES_END);

            UpdateAvailable = CompareSoftwareVersions(LatestVersion);
        }

        private static bool CompareSoftwareVersions(string latestVersion)
        {
            string currentVersion = GetCurrentVersion();

            int result = 0;

            if (latestVersion != null)
            {
                result = latestVersion.CompareTo(currentVersion);
            }

            return (result == 1);
        }

        private static string GetWebRequest(string address)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(address);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            string uriResponse = string.Empty;

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream);

                uriResponse = reader.ReadToEnd();

                stream.Dispose();
            }
            catch (WebException e)
            {
                if (!apiErrorShown)
                {
                    Alert.CreateMessageBox("Endpoint [" + address + "] could not be reached", e, "Utilities.GetWebRequest");
                    apiErrorShown = true;
                }
            }

            return uriResponse;
        }

        public static string ParseOutInfo(string source, string startTag, string endTag)
        {
            if (source.Equals(string.Empty))
            {
                return null;
            }

            Match start = Regex.Match(source, startTag);
            Match end = Regex.Match(source, endTag);

            // +1 and -1 to dispose of leading and trailing colons
            int startIndex = start.Index + start.Length + 1;
            int endIndex = end.Index - 1;

            int length = endIndex - startIndex;

            return source.Substring(startIndex, length);
        }

        public static string GetCurrentVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}
