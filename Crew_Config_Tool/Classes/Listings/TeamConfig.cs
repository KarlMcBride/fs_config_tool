namespace FS_Crew_Config_Tool.Classes.Listings
{
    /// <summary>
    /// Contains enumerations of upto 5 crew, and 3 implants for each crew member
    /// </summary>
    public class TeamConfig
    {
        private const int MAX_CREW_MEMBERS_PER_TEAM = 5;
        private const int MAX_IMPLANTS_PER_CREW_MEMBER = 3;

        public CrewMember[] CrewMembers = new CrewMember[MAX_CREW_MEMBERS_PER_TEAM];

        public class CrewMember
        {
            public CrewEnum CrewID;
            public ImplantEnum[] ImplantIDs;

            public CrewMember()
            {
                CrewID = CrewEnum.NONE;

                ImplantIDs = new ImplantEnum[MAX_IMPLANTS_PER_CREW_MEMBER];

                for (int index = 0; index < MAX_IMPLANTS_PER_CREW_MEMBER; index++)
                {
                    ImplantIDs[index] = ImplantEnum.NONE;
                }
            }
        }

        public TeamConfig()
        {
            CrewMembers = new CrewMember[MAX_CREW_MEMBERS_PER_TEAM];

            for (int i = 0; i < 5; i++)
            {
                CrewMembers[i] = new TeamConfig.CrewMember();
            }
        }
    }
}
