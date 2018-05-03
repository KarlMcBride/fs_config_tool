namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    public static class ConfigUtilities
    {
        public const int CREW_NOT_FOUND = -1;

        /// <summary>
        /// Scans all five crew slots, and checks for any match.
        /// </summary>
        /// <param name="crewEnum">Crew member to check for. Its Role type is used to check against</param>
        /// <param name="selectedTeam">Team config to check against</param>
        /// <returns>Index of match if found (0-4), or -1 if not found</returns>
        public static int CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum crewEnum, TeamConfig selectedTeam)
        {
            int matchIndex = CREW_NOT_FOUND;

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

        public static int FindFirstFreeSlot(TeamConfig selectedTeam)
        {
            int nextFreeSlot = CREW_NOT_FOUND;

            for (int index = 0; index < 5; index++)
            {
                if (selectedTeam.CrewMembers[index].CrewID == CrewEnum.NONE)
                {
                    nextFreeSlot = index;
                    break;
                }
            }

            return nextFreeSlot;
        }
    }
}
