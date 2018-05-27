using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.ConfigManagement;
using System;
using System.Windows.Forms;

namespace FS_Config_Tool.UiComponents
{
    public class QuickShareCodeTextBox : TextBox
    {
        /// <summary>
        /// Generates a code of the format Crew-Imp-Imp-Imp,...Crew-Imp-Imp-Imp
        /// </summary>
        /// <param name="config">Quick share code to generate a crew for</param>
        public void GenerateCode(TeamConfig config)
        {
            string code = string.Empty;

            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                code += (int)config.CrewMembers[crewIndex].CrewID + "-";

                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    code += (int)config.CrewMembers[crewIndex].ImplantIDs[implantIndex];

                    if (implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER - 1)
                    {
                        code += "-";
                    }
                    else if (crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM - 1)
                    {
                        code += ",";
                    }
                }
            }

            Text = code;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            GenerateTeamCode();
            base.OnTextChanged(e);
        }

        private void GenerateTeamCode()
        {
            // Each crew member is separated by an ID tag
            string[] separator = { "-", "," };
            string[] splitCrewCode = Text.Split(separator, StringSplitOptions.None);

            int numOfItems = splitCrewCode.Length;

            TeamConfig generatedCrew = new TeamConfig();

            // Format will be crew-imp-imp-imp, so parsing via a nested loop
            int index = 0;
            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                // If index = numOfItems, we've hit the end of the code early, due to missing delimiters
                if (index == numOfItems)
                {
                    break;
                }

                generatedCrew.CrewMembers[crewIndex].CrewID =
                    ConfigUtilities.ConvertStringToCrewEnum(splitCrewCode[index]);
                index++;

                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    if (index == numOfItems)
                    {
                        break;
                    }

                    generatedCrew.CrewMembers[crewIndex].ImplantIDs[implantIndex] =
                        ConfigUtilities.ConvertStringToImplantEnum(splitCrewCode[index]);
                    index++;
                }
            }
        }
    }
}
