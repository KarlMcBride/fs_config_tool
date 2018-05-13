namespace FS_Config_Tool.Classes.ConfigManagement
{
    using System;
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
                string line = string.Empty;

                if (RawLine == null)
                {
                    // If RawLine is null, this is a new crew, and we'll have to generate the start of the line
                    line = "CrewTeams=(ID=\"";

                    line += GenerateHexString(32);

                    line += "\",Name=\"" + CrewName + "\",Icon=\"";

                }
                else
                {
                    line = ConfigUtilities.GetStartOfRawCrewString(RawLine);
                }

                line += CrewBuilder.GenerateCrewStringFromEnumerations(Team);
                line += ",Members=)";

                return line;
            }

            private static string GenerateHexString(int length)
            {
                const string pool = "0123456789ABCDEF";
                string returnString = string.Empty;

                Random rng = new Random();

                for (int index = 0; index < length; index++)
                {
                    char newChar = pool[rng.Next(0, pool.Length)];
                    returnString += newChar;
                }

                return returnString;
            }
        }
    }
}
