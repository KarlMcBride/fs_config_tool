using FS_Config_Tool.Classes;
using System.Windows.Forms;

namespace FS_Config_Tool.UiComponents
{
    public class QuickShareCodeTextBox : TextBox
    {
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
    }
}
