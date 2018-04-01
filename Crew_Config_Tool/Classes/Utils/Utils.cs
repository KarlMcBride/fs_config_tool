namespace FS_Crew_Config_Tool.Classes.Utilities
{
    public static class ConfigUtilities
    {
        public static void SubstituteBracketsForChevrons(ref string line)
        {
            line = line.Replace("(", "<");
            line = line.Replace(")", ">");
        }
    }
}
