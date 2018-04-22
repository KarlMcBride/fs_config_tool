using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewBox_Test
    {

        [TestMethod]
        public void CrewBox_Load()
        {
            CrewBox asdf = new CrewBox();
            var aaa = asdf.CallHiddenMethod("Return4");
        }

        [TestMethod]
        public void DisplaySelectedCrew_Empty()
        {
            TeamConfig.EnumeratedCrewMember enumeratedCrew = new TeamConfig.EnumeratedCrewMember();

            CrewBox crewBox = new CrewBox();
            crewBox.DisplaySelectedCrew(enumeratedCrew);
        }
    }
}
