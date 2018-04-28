using System.Windows.Forms;

namespace FS_Crew_Config_Tool.Classes
{
    public static class CrewFilter
    {
        public struct CrewTypeFilter
        {
            public bool Cag;
            public bool Captain;
            public bool Comms;
            public bool Engineer;
            public bool JumpCore;
            public bool Nav;
            public bool Repair;
            public bool Tactical;
            public bool Utility;
        }

        public static CrewTypeFilter ConvertCrewFilterBoxesToStruct(CheckBox[] filterCheckBoxes)
        {
            CrewTypeFilter filter = new CrewTypeFilter();

            filter.Cag      = filterCheckBoxes[0].Checked;
            filter.Captain  = filterCheckBoxes[1].Checked;
            filter.Comms    = filterCheckBoxes[2].Checked;
            filter.Engineer = filterCheckBoxes[3].Checked;
            filter.JumpCore = filterCheckBoxes[4].Checked;
            filter.Nav      = filterCheckBoxes[5].Checked;
            filter.Repair   = filterCheckBoxes[6].Checked;
            filter.Tactical = filterCheckBoxes[7].Checked;
            filter.Utility  = filterCheckBoxes[8].Checked;

            return filter;
        }
    }
}
