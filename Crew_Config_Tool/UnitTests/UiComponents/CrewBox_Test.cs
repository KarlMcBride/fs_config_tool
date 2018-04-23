using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewBox_Test
    {

        [TestMethod]
        public void CrewBox_Load()
        {
            CrewBox crewBox = new CrewBox();

            EventArgs e = new EventArgs();
        }

        [TestMethod]
        public void DisplaySelectedCrew_Empty()
        {
            TeamConfig.EnumeratedCrewMember enumeratedCrew = new TeamConfig.EnumeratedCrewMember();

            CrewBox crewBox = new CrewBox();
            crewBox.DisplaySelectedCrew(enumeratedCrew);
        }

        [TestMethod]
        public void DisplaySelectedCrew_Full()
        {
            TeamConfig.EnumeratedCrewMember enumeratedCrew = new TeamConfig.EnumeratedCrewMember();

            enumeratedCrew.CrewID = CrewEnum.DICE_CAPLAN;
            enumeratedCrew.ImplantIDs[0] = ImplantEnum.DAMAGE_REDUCTION;
            enumeratedCrew.ImplantIDs[1] = ImplantEnum.MANEUVERING;
            enumeratedCrew.ImplantIDs[2] = ImplantEnum.REPAIR_EFFICIENCY;

            CrewBox crewBox = new CrewBox();
            crewBox.DisplaySelectedCrew(enumeratedCrew);
        }
    }
}
