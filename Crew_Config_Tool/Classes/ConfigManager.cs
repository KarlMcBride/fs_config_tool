using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Crew_Config_Tool.UiComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FS_Crew_Config_Tool
{
    public class ConfigManager
    {
        private const int UNSELECTED_INDEX = -1;

        private const string FS_PATH = "..\\Local\\spacegame\\Saved\\Config\\WindowsNoEditor\\GameUserSettings.ini";

        private string CompletePath
        {
            get
            {
                string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(appDataDir, FS_PATH);
            }
        }

        private const string CREW_TEAMS_FLAG = "CrewTeams=";

        /// <summary>
        /// Stores first chunk of config e.g. core game settings, ship skin and loadout setups
        /// </summary>
        private List<string> SegmentStart = new List<string>();

        /// <summary>
        /// Stores third chunk of config - ReadItems list and other miscellaneous config items
        /// </summary>
        private List<string> SegmentEnd = new List<string>();

        /// <summary>
        /// Stores raw line data and crew names
        /// </summary>
        public List<CrewLines> CrewData = new List<CrewLines>();

        public struct CrewLines
        {
            public string RawLine;
            public string CrewName;
            public TeamConfig Team;

            public void ParseLine()
            {
                // Use regex to strip out the name
                Match nameTag = Regex.Match(RawLine, "Name=\"");
                Match endOfName = Regex.Match(RawLine, "\",Icon");

                int nameStartIndex = nameTag.Index + nameTag.Length;
                int nameEndIndex = endOfName.Index;

                int length = nameEndIndex - nameStartIndex;

                CrewName = RawLine.Substring(nameStartIndex, length);

                Team = CrewParser.ParseCrewMembersFromLine(RawLine);
            }
        }

        public void LoadConfig()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();

            string[] fullConfig = File.ReadAllLines(CompletePath);

            ParseIntoSegments(fullConfig);
        }

        private void ParseIntoSegments(string[] config)
        {
            int lineNumber = 0;

            bool keepParsing = true;

            // Step 1 - parse each line into SegmentOne until we reach a line containing "CrewTeams"
            while (keepParsing)
            {
                if (config[lineNumber].Contains(CREW_TEAMS_FLAG))
                {
                    // We've hit the crew member section, exit loop
                    keepParsing = false;
                }
                else
                {
                    // Add line to the first segment
                    SegmentStart.Add(config[lineNumber]);
                    lineNumber++;
                }
            }

            // Step 2 - parse each line into SegmentTwo until we add all "CrewTeams" lines
            keepParsing = true;
            while (keepParsing)
            {
                if (config[lineNumber].Contains(CREW_TEAMS_FLAG))
                {
                    CrewLines line = new CrewLines();
                    line.RawLine = config[lineNumber];
                    line.ParseLine();

                    CrewData.Add(line);

                    lineNumber++;
                }
                else
                {
                    // We've hit the end crew member section, exit loop
                    keepParsing = false;
                }
            }

            // Step 3 - parse remaining lines into SegmentThree
            int lineCount = config.Length - 1;
            // Starting value is blank, as we want to use lineNumbers current value
            for (; lineNumber <= lineCount; lineNumber++)
            {
                SegmentEnd.Add(config[lineNumber]);
            }
        }

        public void SortAlphabetically()
        {
            for (int iteration = 0; iteration < CrewData.Count - 1; iteration++)
            {
                for (int index = 0; index < CrewData.Count - 1; index++)
                {
                    /* Return values of String.Compare
                     *
                     * 1  - parameter 1 is alphabetically behind 2
                     * 0  - parameter 1 = 2
                     * -1 - parameter 1 is alphabetically ahead of 2
                    */

                    if (1 == String.Compare(CrewData[index].CrewName, CrewData[index + 1].CrewName))
                    {
                        CrewLines temp = CrewData[index];
                        CrewData[index] = CrewData[index + 1];
                        CrewData[index + 1] = temp;
                    }
                }
            }
        }

        public void SaveConfig()
        {
            using (StreamWriter writetext = new StreamWriter(CompletePath))
            {
                // Write all segment one items
                foreach (string line in SegmentStart)
                {
                    writetext.WriteLine(line);
                }

                // Write all crew lines
                foreach (CrewLines line in CrewData)
                {
                    writetext.WriteLine(line.RawLine);
                }

                // Write all segment three items
                foreach (string line in SegmentEnd)
                {
                    writetext.WriteLine(line);
                }
            }
        }

        public bool DeleteSelectedCrewFromList(int indexToDelete)
        {
            bool deleteSuccessful = false;

            if (CrewData != null)
            {
                if (indexToDelete >= 0 && indexToDelete < CrewData.Count)
                {
                    CrewData.RemoveAt(indexToDelete);
                    deleteSuccessful = true;
                }
            }

            return deleteSuccessful;
        }

        public int GetNextSelectableItem(int currentlySelectedItem, int numOfItems)
        {
            int nextSelectable = UNSELECTED_INDEX;

            // Only calculate if there's 2 or more items present, and an item is selected
            if (currentlySelectedItem > UNSELECTED_INDEX || numOfItems > 1)
            {
                // If last item is selected, decrement by one
                if (currentlySelectedItem == (numOfItems - 1))
                {
                    nextSelectable = currentlySelectedItem - 1;
                }
                else
                {
                    nextSelectable = currentlySelectedItem;
                }
            }

            return nextSelectable;
        }

        public bool AddSelectedMemberToSelectedCrew(string crewName, int selectedTeam)
        {
            CrewEnum selectedCrewID = Utilities.ConvertCrewStringToEnum(crewName);

            bool addSuccessful = false;

            if (selectedCrewID != CrewEnum.NONE && CrewData != null && CrewData.Count > 0 && selectedTeam > UNSELECTED_INDEX)
            {
                int matchIndex =
                    ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(selectedCrewID, CrewData[selectedTeam].Team);

                // If the selected crew member is a captain, add it into the middle slot
                if (CrewList.CrewListing[(int)selectedCrewID].Role == CrewRole.CAPTAIN)
                {
                    CrewData[selectedTeam].Team.CrewMembers[ConfigUtilities.CAPTAIN_SLOT].CrewID = selectedCrewID;
                    addSuccessful = true;
                }
                // Swap out the current crew in the set with the newly selected one if its role matches
                else if (matchIndex != ConfigUtilities.OUT_OF_BOUNDS)
                {
                    CrewData[selectedTeam].Team.CrewMembers[matchIndex].CrewID = selectedCrewID;
                    addSuccessful = true;
                }
                else if (ConfigUtilities.CountNumberOfCrewInTeam(CrewData[selectedTeam].Team) < 5)
                {
                    int nextFreeSlot = ConfigUtilities.FindFirstFreeSlotForNonCaptain(CrewData[selectedTeam].Team);

                    if (nextFreeSlot > ConfigUtilities.OUT_OF_BOUNDS)
                    {
                        CrewData[selectedTeam].Team.CrewMembers[nextFreeSlot].CrewID = selectedCrewID;
                        addSuccessful = true;
                    }
                }
            }

            return addSuccessful;
        }

        public bool RemoveSelectedCrewMember(int selectedTeam, int crewIndexToRemove)
        {
            bool removeSuccessful = false;

            if (CrewData[selectedTeam].Team.CrewMembers[crewIndexToRemove].CrewID != CrewEnum.NONE)
            {
                CrewData[selectedTeam].Team.CrewMembers[crewIndexToRemove].CrewID = CrewEnum.NONE;
                removeSuccessful = true;
            }

            return removeSuccessful;
        }

        public bool RemoveSelectedCrewImplant(int selectedTeam, UiArguments args)
        {
            bool removeSuccessful = false;

            if (CrewData[selectedTeam].Team.CrewMembers[args.CrewIndex].ImplantIDs[args.ImplantIndex] != ImplantEnum.NONE)
            {
                CrewData[selectedTeam].Team.CrewMembers[args.CrewIndex].ImplantIDs[args.ImplantIndex] = ImplantEnum.NONE;
                removeSuccessful = true;
            }

            return removeSuccessful;
        }
    }
}
