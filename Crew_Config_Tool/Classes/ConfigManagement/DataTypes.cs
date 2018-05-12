namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    using System.Text.RegularExpressions;

    namespace FS_Crew_Config_Tool.Classes.ConfigManagement
    {
        public struct CrewLines
        {
            public string RawLine;
            public string CrewName;
            public TeamConfig Team;

            public void ParseLine()
            {
                // Use regex to strip out the name
                Match nameTag = Regex.Match(RawLine, "Name=\"");
                Match endOfName = Regex.Match(RawLine, "\",Icon");

                int nameStartIndex = nameTag.Index + nameTag.Length;
                int nameEndIndex = endOfName.Index;

                int length = nameEndIndex - nameStartIndex;

                // Range check the values, or we can cause OOR exceptions
                if (nameStartIndex > -1 && length > -1)
                {
                    CrewName = RawLine.Substring(nameStartIndex, length);

                    Team = CrewParser.ParseCrewMembersFromLine(RawLine);
                }
                else
                {
                    CrewName = "Undefined";
                }
            }

            public string BuildLine()
            {
                string line = ConfigUtilities.GetStartOfRawCrewString(RawLine);
                line += CrewBuilder.GenerateCrewStringFromEnumerations(Team);
                line += ",Members=)";

                return line;
            }
        }
    }

}
