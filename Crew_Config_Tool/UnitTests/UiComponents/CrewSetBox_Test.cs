using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewSetBox_Test
    {
        [TestMethod]
        public void CrewBox_Load()
        {
            CrewBox crewBox = new CrewBox();

            EventArgs e = new EventArgs();

            crewBox.CallHiddenMethod("CrewBox_Load", crewBox, e);
        }

        [TestMethod]
        public void DisplayFullCrew()
        {
            CrewSetBox crewSetBox = new CrewSetBox();
            crewSetBox.DisplaySelectedTeam(ParsedData.FiveMembersFullImplantsOrdered(), null);
        }
    }
}
