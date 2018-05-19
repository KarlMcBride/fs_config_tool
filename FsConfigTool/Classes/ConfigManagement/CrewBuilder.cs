namespace FS_Config_Tool.Classes.ConfigManagement
{
    public static class CrewBuilder
    {
        // Single crew member format - empty    : ()
        // Single crew member format - crew only: (ID=\"F54C19614EED261DE7B5688440419793\")
        // Single crew member format - full     : (ID =\"34D3B51248D2D71DA09F49B70D527191\",Affinities=(\"E0DF7C9441151ED8AFD4ED9BF12DE8B6\",\"B553F54842EF2379C90DF49836292A76\",\"EC1EE1F84F43B42461FD848FB3433529\")"

        public static string GenerateCrewStringFromEnumerations(TeamConfig teamConfig)
        {
            string teamString = "(";

            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                teamString += GenerateSingleCrewMemberComponent(teamConfig.CrewMembers[crewIndex]);

                if (crewIndex < 4)
                {
                    teamString += ",";
                }
            }

            teamString += ")";

            return teamString;
        }

        public static string GenerateSingleCrewMemberComponent(TeamConfig.EnumeratedCrewMember crewMember)
        {
            string crewString = "(";

            // If there's no crew member, just wrap up to make a "()"
            if (crewMember.CrewID == CrewEnum.END_OF_LIST)
            {
                crewString += ")";
            }
            else
            {
                crewString += "ID=\"" + CrewList.CrewListing[(int)crewMember.CrewID].Code + "\"";

                int numOfImplants = ConfigUtilities.CountNumberOfImplantsInCrewMember(crewMember);

                // If there's no implants, close up the brackets
                if (numOfImplants == 0)
                {
                    crewString += ")";
                }
                else
                {
                    crewString += ",Affinities=(\"";

                    for (int implantIndex = 0; implantIndex < numOfImplants; implantIndex++)
                    {
                        int implantID = (int)crewMember.ImplantIDs[implantIndex];

                        crewString += ImplantList.ImplantListing[implantID].Code + "\"";

                        // If there's at least one more to go, append a comma and speech mark to match the expected format
                        if (implantIndex + 1 < numOfImplants)
                        {
                            crewString += ",\"";
                        }
                    }

                    // Close off the implant's "affinities" brackets
                    crewString += ")";

                    // Close off the crew's outer brackets
                    crewString += ")";
                }
            }

            return crewString;
        }
    }
}
