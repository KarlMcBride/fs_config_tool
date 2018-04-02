namespace FS_Crew_Config_Tool.Classes
{
    public static class Utils
    {
        public static bool IsCrewMemberCaptain(CrewEnum id)
        {
            bool isCaptain = false;

            for (int crewID = (int)CrewEnum.CAESAR_MORGAN; crewID <= (int)CrewEnum.WHIM; crewID++)
            {
                if (id == (CrewEnum)crewID)
                {
                    isCaptain = true;
                    break;
                }
            }

            return isCaptain;
        }
    }
}
