namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    public static class ConfigUtilities
    {
        /// <summary>
        /// Scans all five crew slots, and checks for any match.
        /// </summary>
        /// <param name="crewEnum">Crew member to check for. Its Role type is used to check against</param>
        /// <param name="selectedTeam">Team config to check against</param>
        /// <returns>True if matching role is present, otherwise false</returns>
        public static bool CheckCrewTeamForSelectedMembersRoleIsPresent(CrewEnum crewEnum, TeamConfig selectedTeam)
        {
            bool isRolePresent = false;

            CrewRole selectedRole = (crewEnum == CrewEnum.NONE) ? CrewRole.NONE : CrewList.CrewListing[(int)crewEnum].Role;

            for (int index = 0; index < 5; index++)
            {
                int crewIndex = (int)selectedTeam.CrewMembers[index].CrewID;

                if (crewIndex < (int)CrewEnum.NONE)
                {
                    CrewRole currentRole = CrewList.CrewListing[crewIndex].Role;

                    if (selectedRole == currentRole)
                    {
                        isRolePresent = true;
                        break;
                    }
                }
            }

            return isRolePresent;
        }
    }
}
