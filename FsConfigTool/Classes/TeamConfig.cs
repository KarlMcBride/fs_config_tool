namespace FS_Config_Tool.Classes
{
    /// <summary>
    /// Contains enumerations of upto 5 crew, and 3 implants for each crew member
    /// </summary>
    public class TeamConfig
    {
        public const int MAX_CREW_MEMBERS_PER_TEAM = 5;
        public const int MAX_IMPLANTS_PER_CREW_MEMBER = 3;

        public EnumeratedCrewMember[] CrewMembers = new EnumeratedCrewMember[MAX_CREW_MEMBERS_PER_TEAM];

        public class EnumeratedCrewMember
        {
            public CrewEnum CrewID;
            public ImplantEnum[] ImplantIDs;

            public EnumeratedCrewMember()
            {
                CrewID = CrewEnum.END_OF_LIST;

                ImplantIDs = new ImplantEnum[MAX_IMPLANTS_PER_CREW_MEMBER];

                for (int index = 0; index < MAX_IMPLANTS_PER_CREW_MEMBER; index++)
                {
                    ImplantIDs[index] = ImplantEnum.END_OF_LIST;
                }
            }
        }

        public TeamConfig()
        {
            CrewMembers = new EnumeratedCrewMember[MAX_CREW_MEMBERS_PER_TEAM];

            for (int i = 0; i < MAX_CREW_MEMBERS_PER_TEAM; i++)
            {
                CrewMembers[i] = new TeamConfig.EnumeratedCrewMember();
            }
        }
    }
}
