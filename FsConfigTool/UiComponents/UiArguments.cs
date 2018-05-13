using System;
using System.Windows.Forms;

namespace FS_Config_Tool.UiComponents
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

    public class ShipArgs : EventArgs
    {
        public ShipArgs(CheckBox[] checkBoxArray)
        {
            ArrayLength = checkBoxArray.Length;

            ShipSelectionArray = new bool[ArrayLength];

            for (int index = 0; index < ArrayLength; index++)
            {
                ShipSelectionArray[index] = checkBoxArray[index].Checked;
            }
        }

        public int    ArrayLength        { get; private set; }
        public bool[] ShipSelectionArray { get; private set; }
    }
}
