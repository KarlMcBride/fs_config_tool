using System.Text.RegularExpressions;

namespace FS_Config_Tool.Classes.ConfigManagement
{
    public static class ConfigUtilities
    {
        public struct CrewImplantIndexStruct
        {
            public bool EmptySlotFound  { get; private set; }
            public int CrewIndex        { get; private set; }
            public int ImplantIndex     { get; private set; }

            public CrewImplantIndexStruct(bool emptySlotFound)
            {
                EmptySlotFound = emptySlotFound;
                CrewIndex = OUT_OF_BOUNDS;
                ImplantIndex = OUT_OF_BOUNDS;
            }

            public CrewImplantIndexStruct(bool emptySlotFound, int crewIndex, int implantIndex)
            {
                EmptySlotFound = emptySlotFound;

                if (emptySlotFound)
                {
                    CrewIndex = crewIndex;
                    ImplantIndex = implantIndex;
                }
                else
                {
                    CrewIndex = OUT_OF_BOUNDS;
                    ImplantIndex = OUT_OF_BOUNDS;
                }
            }
        }

        public const int OUT_OF_BOUNDS = -1;
        public const int CAPTAIN_SLOT = 2;

        /// <summary>
        /// Scans all five crew slots, and checks for any match.
        /// </summary>
        /// <param name="crewEnum">Crew member to check for. Its Role type is used to check against</param>
        /// <param name="selectedTeam">Team config to check against</param>
        /// <returns>Index of match if found (0-4), or -1 if not found</returns>
        public static int CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum crewEnum, TeamConfig selectedTeam)
        {
            // Don't continue if a proper crew enum hasn't been passed in
            if (crewEnum == CrewEnum.END_OF_LIST)
            {
                return -1;
            }

            int matchIndex = OUT_OF_BOUNDS;

            CrewRole selectedRole = CrewList.CrewListing[(int)crewEnum].Role;

            for (int index = 0; index < 5; index++)
            {
                int crewIndex = (int)selectedTeam.CrewMembers[index].CrewID;

                if (crewIndex < (int)CrewEnum.END_OF_LIST)
                {
                    CrewRole currentRole = CrewList.CrewListing[crewIndex].Role;

                    if (selectedRole == currentRole)
                    {
                        matchIndex = index;
                        break;
                    }
                }
            }

            return matchIndex;
        }

        /// <summary>
        /// Counts the number of crew members in the team i.e. CrewID != CrewEnum.NONE
        /// </summary>
        /// <param name="selectedTeam">Team to run a count on</param>
        /// <returns>Int number of crew in team</returns>
        public static int CountNumberOfCrewInTeam(TeamConfig selectedTeam)
        {
            int crewCount = 0;

            for (int index = 0; index < 5; index++)
            {
                if (selectedTeam.CrewMembers[index].CrewID != CrewEnum.END_OF_LIST)
                {
                    crewCount++;
                }
            }

            return crewCount;
        }

        public static int FindFirstFreeSlotForNonCaptain(TeamConfig selectedTeam)
        {
            int nextFreeSlot = OUT_OF_BOUNDS;

            for (int index = 0; index < 5; index++)
            {
                if (index == 2)
                {
                    // Skip the captain's slot, effectively reserving it for captains
                    continue;
                }
                if (selectedTeam.CrewMembers[index].CrewID == CrewEnum.END_OF_LIST)
                {
                    nextFreeSlot = index;
                    break;
                }
            }

            return nextFreeSlot;
        }

        /// <summary>
        /// Counts the number of implants members in the team i.e. ImplantID != ImplantEnum.NONE
        /// </summary>
        /// <param name="selectedTeam">Team to run a count on</param>
        /// <returns>Int number of implants in team</returns>
        public static int CountNumberOfImplantsInTeam(TeamConfig selectedTeam)
        {
            int implantCount = 0;

            for (int crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                implantCount += CountNumberOfImplantsInCrewMember(selectedTeam.CrewMembers[crewIndex]);
            }

            return implantCount;
        }

        /// <summary>
        /// Counts the number of implants of a given crew member
        /// </summary>
        /// <param name="selectedCrew">Crew member to run a count on</param>
        /// <returns>Int number of implants in crew member</returns>
        public static int CountNumberOfImplantsInCrewMember(TeamConfig.EnumeratedCrewMember selectedCrew)
        {
            int implantCount = 0;

            for (int implantIndex = 0; implantIndex < 3; implantIndex++)
            {
                if (selectedCrew.ImplantIDs[implantIndex] != ImplantEnum.END_OF_LIST)
                {
                    implantCount++;
                }
            }

            return implantCount;
        }

        public static CrewImplantIndexStruct FindFirstFreeImplantSlotWithoutDuplication(TeamConfig selectedTeam, ImplantEnum implantID)
        {
            bool emptySlotFound = false;
            int crewIndex = 0;
            int implantIndex = 0;

            for (crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                int implantSlotsChecked = 0;
                int emptySlot = -1;

                for (implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    if (selectedTeam.CrewMembers[crewIndex].ImplantIDs[implantIndex] == ImplantEnum.END_OF_LIST)
                    {
                        // Hold onto the first empty slot
                        if (emptySlot == -1)
                        {
                            emptySlot = implantIndex;
                        }
                        implantSlotsChecked++;
                    }
                    else if (selectedTeam.CrewMembers[crewIndex].ImplantIDs[implantIndex] != implantID)
                    {
                        implantSlotsChecked++;
                    }
                }

                // If the current implant doesn't match any of the current slots, then 
                if (implantSlotsChecked == 3 && emptySlot > -1)
                {
                    emptySlotFound = true;
                    implantIndex = emptySlot;
                    break;
                }
            }

            return new CrewImplantIndexStruct(emptySlotFound, crewIndex, implantIndex);
        }

        public static string GetStartOfRawCrewString(string rawString)
        {
            // After ship-crew links, name, icon and member tags
            Match endOfStart = Regex.Match(rawString, "CrewMembers=");
            
            int endOfStartIndex = endOfStart.Index + endOfStart.Length;

            string returnString = rawString.Substring(0, endOfStartIndex);

            return returnString;
        }
    }
}
