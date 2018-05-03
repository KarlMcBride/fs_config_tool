using FS_Crew_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewSetBox_Test
    {
        private const bool EXPECTING_IMAGE = true;
        private const bool EXPECTING_NULL = false;

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

            for(int index = 0; index < 5; index++)
            {
                Assert.IsNotNull(crewSetBox.CheckCrewImageState(index, EXPECTING_IMAGE));
            }
        }

        [TestMethod]
        public void ClearBlankCrew()
        {
            CrewSetBox crewSetBox = new CrewSetBox();
            crewSetBox.ClearDisplayedTeam(null);

            for (int index = 0; index < 5; index++)
            {
                Assert.IsNotNull(crewSetBox.CheckCrewImageState(index, EXPECTING_NULL));
            }
        }

        [TestMethod]
        public void ClearFullCrew()
        {
            CrewSetBox crewSetBox = new CrewSetBox();
            crewSetBox.DisplaySelectedTeam(ParsedData.FiveMembersFullImplantsOrdered(), null);
            crewSetBox.ClearDisplayedTeam(null);

            for (int index = 0; index < 5; index++)
            {
                Assert.IsNotNull(crewSetBox.CheckCrewImageState(index, EXPECTING_NULL));
            }
        }
    }
}
