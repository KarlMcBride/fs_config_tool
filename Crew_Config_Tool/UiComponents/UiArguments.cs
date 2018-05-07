using System;

namespace FS_Crew_Config_Tool.UiComponents
{
    public class UiArguments : EventArgs
    {
        public UiArguments(int crew, int implant)
        {
            if (crew >= 4 || crew < -1)
            {
                crew = -1;
            }
            CrewIndex = crew;

            if (implant >= 3 || implant < -1)
            {
                implant = -1;
            }
            ImplantIndex = implant;
        }

        public int CrewIndex    { get; private set; }
        public int ImplantIndex { get; private set; }
    }
}
