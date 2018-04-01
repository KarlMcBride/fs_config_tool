using FS_Crew_Config_Tool.Classes.Listings;
using FS_Crew_Config_Tool.Classes.Utilities;
using System.Text.RegularExpressions;

namespace FS_Crew_Config_Tool.Classes.ConfigManagement
{
    /*
     *
CrewTeams=(ID="C88443774D6346F59F4E1DA8F94529F2",Name="Crew Only",Icon="",CrewMembers=((ID="FFBB0CD044585FA20397788DA4C8361B"),(ID="00CF4ABB4849164394475884CDBD2FA2"),(ID="BA551FBC4960C181F355B980AF657DCE"),(ID="C9E1CF554D3AA9ABBEACC29081923251"),(ID="10D3DC5F47D80063D389A39B9E43C83A")),Members=)
CrewTeams=(ID="A6020E8742316B0810DA9C90B8F80840",Name="Captain+Imp",Icon="",CrewMembers=((),(),(ID="469C924F46938892882C86B29AEC0787",Affinities=("A7C4002144908C578C82EAACEED842B3")),(),()),Members=)
CrewTeams=(ID="BB538863470490BFC88B5D8DEE747AF4",Name="Captain+2Imp",Icon="",CrewMembers=((),(),(ID="A3E3FD2D4F8A3A7B3C3ED392FDA7A83A",Affinities=("EC9B721447DF397CA0D7D0A1AEA12A0F","5A718C99471772C79A8B90A146601748")),(),()),Members=)
CrewTeams=(ID="3E37B1914635EE5248EB48BCE5A09DB7",Name="Captain+3Imp",Icon="",CrewMembers=((),(),(ID="114452A14736870E083AE9A565A66D32",Affinities=("13DC022E42068C9E654115A05B41DE6E","2EC7537F4193727447AC74B5A340345A","D3D9388C4A69F429C161E18C7978B5A4")),(),()),Members=)
CrewTeams=(ID="C3ED77E04FCB6D1876D4F2AFD372E00E",Name="The Opportunists",Icon="",CrewMembers=((),(),(),(),()),Members=)
     *
     */

    public static class Parser
    {
        /// <summary>
        /// Strips the crew ID's and implants out of the line
        /// </summary>
        /// <param name="line">Line to parse</param>
        /// <returns>string in format "(#crew1),(#crew2),(#crew3),(#crew4),(#crew5)"</returns>
        public static string ParseCrewMemberSection(string line)
        {
            // Strip out ship-crew links, name, icon and member tags
            Match crewStart = Regex.Match(line, "CrewMembers=");
            Match CrewEnd = Regex.Match(line, ",Members=");

            // +1 and -1 to dispose of leading and trailing brackets
            int crewStartIndex = crewStart.Index + crewStart.Length + 1;
            int crewEndIndex = CrewEnd.Index - 1;

            int length = crewEndIndex - crewStartIndex;

            return line.Substring(crewStartIndex, length);
        }

        public static TeamConfig ParseCrewMembersFromSection(string section)
        {
            // Substitute () for <> as regex complains about brackets
            ConfigUtilities.SubstituteBracketsForChevrons(ref section);

            TeamConfig config = new TeamConfig();

            // Each crew member is separated by an ID tag
            string[] separator = { "ID" };

            // This will produce an array of size 7. Index 0 will be "CrewMembers", 1 will be crew name + ID, 2-6 will be crew members
            string[] splitSection = section.Split(separator, System.StringSplitOptions.None);

            for (int index = 2; index < 7; index++)
            {
                config.CrewMembers[index - 2] = GetCrewMemberFromString(splitSection[index]);
            }

            return config;
        }

        public static TeamConfig.CrewMember GetCrewMemberFromString(string input)
        {
            TeamConfig.CrewMember crewMember = new TeamConfig.CrewMember();

            // Find the crew member's string from the list
            foreach (CrewEnum id in CrewEnum.GetValues(typeof(CrewEnum)))
            {
                if (input.Contains(CrewList.CrewListing[(int)id].Code))
                {
                    // We've found a match, so assign and break out
                    crewMember.CrewID = id;
                    break;
                }
            }

            // Parse implants if crew member was found
            if (crewMember.CrewID != CrewEnum.NONE)
            {
                int implantNumber = 0;

                for (int implantId = 0; implantId < (int)ImplantEnum.NONE - 1; implantId++)
                {
                    if (input.Contains(ImplantList.ImplantListing[implantId].Code))
                    {
                        // We've found a match, so assign, increment and carry on
                        crewMember.ImplantIDs[implantNumber] = (ImplantEnum)implantId;
                        implantNumber++;

                        if (implantNumber == 3)
                        {
                            // We've got 3 implants so break out
                            break;
                        }
                    }
                }
            }

            return crewMember;
        }
    }
}