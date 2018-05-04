using System;

namespace FS_Crew_Config_Tool.UiComponents
{
    public class UiArguments : EventArgs
    {
        public UiArguments(int crew, int implant)
        {
            CrewIndex = crew;
            ImplantIndex = implant;
        }

        public int CrewIndex    { get; private set; }
        public int ImplantIndex { get; private set; }
    }
}
