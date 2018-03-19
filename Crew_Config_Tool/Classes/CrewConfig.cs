using System.Collections.Generic;

namespace FS_Crew_Config_Tool.Classes
{
    public class CrewConfig
    {
        private struct Config
        {
            // CrewTeams=(ID="32 HEX DIGITS",Name="
            string StartingBlock;
            // Name of config - e.g. Paladin Jump Prep
            string CrewConfigName;
            // ",Icon="",CrewMembers=...,Members=)
            string RemainingBlock;
        }

        private List<Config> Configs = new List<Config>();
    }
}
