using System;

namespace FS_Crew_Config_Tool.UiComponents
{
    public class CrewArgs : EventArgs
    {
        public CrewArgs(int crew)
        {
            if (crew > 4 || crew < -1)
            {
                crew = -1;
            }
            CrewIndex = crew;
        }

        public int CrewIndex { get; private set; }
    }

    public class CrewImplantArgs : EventArgs
    {
        public CrewImplantArgs(int crew, int implant)
        {
            if (crew > 4 || crew < -1)
            {
                crew = -1;
            }
            CrewIndex = crew;

            if (implant > 2 || implant < -1)
            {
                implant = -1;
            }
            ImplantIndex = implant;
        }

        public int CrewIndex    { get; private set; }
        public int ImplantIndex { get; private set; }
    }
}
