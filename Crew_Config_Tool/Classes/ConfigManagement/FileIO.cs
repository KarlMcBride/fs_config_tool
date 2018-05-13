using FS_Crew_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using System;
using System.IO;

namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    public class FileIO
    {
        private const string FS_PATH = "..\\Local\\spacegame\\Saved\\Config\\WindowsNoEditor\\";
        private const string CONFIG_FILE_NAME = "GameUserSettings.ini";

        private string CompletePath
        {
            get
            {
                string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(appDataDir, FS_PATH, CONFIG_FILE_NAME);
            }
        }

        public string[] ReadConfig()
        {
            string[] fullConfig = null;

            try
            {
                fullConfig = File.ReadAllLines(CompletePath);
            }
            catch (DirectoryNotFoundException e)
            {
                Alert.CreateMessageBox("FS directory could not be found", e, "FileIO:ReadConfig");
            }
            catch (FileNotFoundException e)
            {
                Alert.CreateMessageBox("FS config file could not be found", e, "FileIO:ReadConfig");
            }

            return fullConfig;
        }

        public void SaveConfig(DataListings dataLists)
        {
            using (StreamWriter writetext = new StreamWriter(CompletePath))
            {
                // Write all segment one items
                foreach (string line in dataLists.SegmentStart)
                {
                    writetext.WriteLine(line);
                }

                // Write all crew lines
                foreach (CrewLines line in dataLists.CrewData)
                {
                    writetext.WriteLine(line.BuildLine());
                }

                // Write all segment three items
                foreach (string line in dataLists.SegmentEnd)
                {
                    writetext.WriteLine(line);
                }
            }
        }
    }
}
