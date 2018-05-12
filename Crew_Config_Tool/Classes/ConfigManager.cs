using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Crew_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using FS_Crew_Config_Tool.Classes.Listings;
using FS_Crew_Config_Tool.UiComponents;
using System;

namespace FS_Crew_Config_Tool
{
    public class ConfigManager
    {
        private const int UNSELECTED_INDEX = -1;

        private const string CREW_TEAMS_FLAG = "CrewTeams=";

        public DataListings DataLists;
        public FileIO FileIO;

        /// <summary>
        /// Class constructor - populates crew & implant lists
        /// </summary>
        public ConfigManager()
        {
            StatList.PopulateStatsList();
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();

            DataLists = new DataListings();
            FileIO = new FileIO();
        }

        public void LoadConfig()
        {
            string[] fullConfig = FileIO.ReadConfig();

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
                    DataLists.SegmentStart.Add(config[lineNumber]);
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

                    DataLists.CrewData.Add(line);

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
                DataLists.SegmentEnd.Add(config[lineNumber]);
            }
        }

        public void SortAlphabetically()
        {
            for (int iteration = 0; iteration < DataLists.CrewData.Count - 1; iteration++)
            {
                for (int index = 0; index < DataLists.CrewData.Count - 1; index++)
                {
                    /* Return values of String.Compare
                     *
                     * 1  - parameter 1 is alphabetically behind 2
                     * 0  - parameter 1 = 2
                     * -1 - parameter 1 is alphabetically ahead of 2
                    */

                    if (1 == String.Compare(DataLists.CrewData[index].CrewName, DataLists.CrewData[index + 1].CrewName))
                    {
                        CrewLines temp = DataLists.CrewData[index];
                        DataLists.CrewData[index] = DataLists.CrewData[index + 1];
                        DataLists.CrewData[index + 1] = temp;
                    }
                }
            }
        }

        public void SaveConfig()
        {
            FileIO.SaveConfig(DataLists);
        }

        public bool DeleteSelectedCrewFromList(int indexToDelete)
        {
            bool deleteSuccessful = false;

            if (DataLists.CrewData != null)
            {
                if (indexToDelete >= 0 && indexToDelete < DataLists.CrewData.Count)
                {
                    DataLists.CrewData.RemoveAt(indexToDelete);
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

            if (selectedCrewID != CrewEnum.END_OF_LIST && DataLists.CrewData != null && DataLists.CrewData.Count > 0
                    && selectedTeam > UNSELECTED_INDEX)
            {
                int matchIndex =
                    ConfigUtilities.CheckCrewTeamForSelectedMembersRoleIsPresent(selectedCrewID, DataLists.CrewData[selectedTeam].Team);

                // If the selected crew member is a captain, add it into the middle slot
                if (CrewList.CrewListing[(int)selectedCrewID].Role == CrewRole.CAPTAIN)
                {
                    DataLists.CrewData[selectedTeam].Team.CrewMembers[ConfigUtilities.CAPTAIN_SLOT].CrewID = selectedCrewID;
                    addSuccessful = true;
                }
                // Swap out the current crew in the set with the newly selected one if its role matches
                else if (matchIndex != ConfigUtilities.OUT_OF_BOUNDS)
                {
                    DataLists.CrewData[selectedTeam].Team.CrewMembers[matchIndex].CrewID = selectedCrewID;
                    addSuccessful = true;
                }
                else if (ConfigUtilities.CountNumberOfCrewInTeam(DataLists.CrewData[selectedTeam].Team) < 5)
                {
                    int nextFreeSlot = ConfigUtilities.FindFirstFreeSlotForNonCaptain(DataLists.CrewData[selectedTeam].Team);

                    if (nextFreeSlot > ConfigUtilities.OUT_OF_BOUNDS)
                    {
                        DataLists.CrewData[selectedTeam].Team.CrewMembers[nextFreeSlot].CrewID = selectedCrewID;
                        addSuccessful = true;
                    }
                }
            }

            return addSuccessful;
        }

        public bool RemoveSelectedCrewMember(int selectedTeam, int crewIndexToRemove)
        {
            bool removeSuccessful = false;

            if (DataLists.CrewData[selectedTeam].Team.CrewMembers[crewIndexToRemove].CrewID != CrewEnum.END_OF_LIST)
            {
                DataLists.CrewData[selectedTeam].Team.CrewMembers[crewIndexToRemove].CrewID = CrewEnum.END_OF_LIST;
                removeSuccessful = true;
            }

            return removeSuccessful;
        }

        public bool AddSelectedImplantToNextFreeSlot(string implantName, int selectedTeam)
        {
            bool addSuccessful = false;

            ImplantEnum selectedImplantID = Utilities.ConvertImplantStringToEnum(implantName);

            if (selectedImplantID != ImplantEnum.END_OF_LIST && DataLists.CrewData != null && DataLists.CrewData.Count > 0
                    && selectedTeam > UNSELECTED_INDEX)
            {
                if (ConfigUtilities.CountNumberOfImplantsInTeam(DataLists.CrewData[selectedTeam].Team) < 15)
                {
                    ConfigUtilities.CrewImplantIndexStruct nextFreeSlot = 
                        ConfigUtilities.FindFirstFreeImplantSlotWithoutDuplication(DataLists.CrewData[selectedTeam].Team, selectedImplantID);

                    if (nextFreeSlot.EmptySlotFound)
                    {
                        DataLists.CrewData[selectedTeam].Team.CrewMembers[nextFreeSlot.CrewIndex].ImplantIDs[nextFreeSlot.ImplantIndex] = selectedImplantID;
                        addSuccessful = true;
                    }
                }
            }

            return addSuccessful;
        }

        public bool RemoveSelectedCrewImplant(int selectedTeam, CrewImplantArgs args)
        {
            bool removeSuccessful = false;

            if (DataLists.CrewData[selectedTeam].Team.CrewMembers[args.CrewIndex].ImplantIDs[args.ImplantIndex] != ImplantEnum.END_OF_LIST)
            {
                DataLists.CrewData[selectedTeam].Team.CrewMembers[args.CrewIndex].ImplantIDs[args.ImplantIndex] = ImplantEnum.END_OF_LIST;
                removeSuccessful = true;
            }

            return removeSuccessful;
        }
    }
}
