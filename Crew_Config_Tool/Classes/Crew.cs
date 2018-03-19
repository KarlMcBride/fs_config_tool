using System.Collections.Generic;

namespace FS_Crew_Config_Tool
{
    enum CrewRole
    {
        CAG,
        CAPTAIN,
        COMMS,
        ENGINEER,
        JUMP_CORE,
        NAV_OFFICER,
        REPAIR,
        TACTICAL,
        UTILITY
    }

    struct CrewMember
    {
        string Name;
        CrewRole Role;
    }

    public class CrewList
    {
        List<CrewMember> CrewListing;

        public void PopulateCrewList()
        {
            CrewListing = new List<CrewMember>();

        }
    }
}
