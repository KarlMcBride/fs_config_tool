using FS_Crew_Config_Tool.Classes.ConfigManagement.FS_Crew_Config_Tool.Classes.ConfigManagement;
using System.Collections.Generic;

namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    public class DataListings
    {
        /// <summary>
        /// Stores first chunk of config e.g. core game settings, ship skin and loadout setups
        /// </summary>
        public List<string> SegmentStart = new List<string>();

        /// <summary>
        /// Stores third chunk of config - ReadItems list and other miscellaneous config items
        /// </summary>
        public List<string> SegmentEnd = new List<string>();

        /// <summary>
        /// Stores raw line data and crew names
        /// </summary>
        public List<CrewLines> CrewData = new List<CrewLines>();
    }
}
