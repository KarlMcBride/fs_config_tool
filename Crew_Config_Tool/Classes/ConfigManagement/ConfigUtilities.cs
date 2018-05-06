namespace FS_Crew_Config_Tool.Classes.ConfigManagement
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
                CrewIndex = -1;
                ImplantIndex = -1;
            }

            public CrewImplantIndexStruct(bool emptySlotFound, int crewIndex, int implantIndex)
            {
                EmptySlotFound = emptySlotFound;
                CrewIndex = crewIndex;
                ImplantIndex = implantIndex;
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
            int matchIndex = OUT_OF_BOUNDS;

            CrewRole selectedRole = (crewEnum == CrewEnum.NONE) ? CrewRole.NONE : CrewList.CrewListing[(int)crewEnum].Role;

            for (int index = 0; index < 5; index++)
            {
                int crewIndex = (int)selectedTeam.CrewMembers[index].CrewID;

                if (crewIndex < (int)CrewEnum.NONE)
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
                if (selectedTeam.CrewMembers[index].CrewID != CrewEnum.NONE)
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
                if (selectedTeam.CrewMembers[index].CrewID == CrewEnum.NONE)
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
                for (int implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    if (selectedTeam.CrewMembers[crewIndex].ImplantIDs[implantIndex] != ImplantEnum.NONE)
                    {
                        implantCount++;
                    }
                }
            }

            return implantCount;
        }

        public static CrewImplantIndexStruct FindFirstFreeImplantSlot(TeamConfig selectedTeam)
        {
            bool emptySlotFound = false;
            int crewIndex = 0;
            int implantIndex = 0;

            for (crewIndex = 0; crewIndex < 5; crewIndex++)
            {
                for (implantIndex = 0; implantIndex < 3; implantIndex++)
                {
                    if (selectedTeam.CrewMembers[crewIndex].ImplantIDs[implantIndex] == ImplantEnum.NONE)
                    {
                        emptySlotFound = true;
                        return new CrewImplantIndexStruct(emptySlotFound, crewIndex, implantIndex);
                    }
                }
            }

            return new CrewImplantIndexStruct(emptySlotFound);
        }
    }
}
