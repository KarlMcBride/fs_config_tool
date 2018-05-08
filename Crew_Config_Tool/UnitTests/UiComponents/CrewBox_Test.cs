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
        private int CrewIndex;
        /// <summary>
        /// Helper method for receiving injected crew events
        /// </summary>
        private void CrewReceiver(object sender, CrewArgs e)
        {
            CrewIndex = e.CrewIndex;
        }

        private int ImplantIndex;
        /// <summary>
        /// Helper method for receiving injected crew implant events
        /// </summary>
        private void CrewImplantReceiver(object sender, CrewImplantArgs e)
        {
            CrewIndex = e.CrewIndex;
            ImplantIndex = e.ImplantIndex;
        }


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

            Assert.IsFalse(crewBox.CheckDisplayedCrewImage());

            for (int implantIndex = 0; implantIndex < 3; implantIndex++)
            {
                Assert.IsFalse(crewBox.CheckDisplayedImplantImage(implantIndex));
            }
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

            for (int implantIndex = 0; implantIndex < 3; implantIndex++)
            {
                Assert.IsTrue(crewBox.CheckDisplayedImplantImage(implantIndex));
            }
        }

        [TestMethod]
        public void DoubleClickCrew()
        {
            CrewBox crewBox = new CrewBox();

            crewBox.CrewMemberDoubleClicked += CrewReceiver;

            for(int index = 0; index < 5; index++)
            {
                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxCrew_MouseDoubleClick", null, null);
                Assert.AreEqual(index, CrewIndex, "Crew index args do not match");
            }
        }

        [TestMethod]
        public void DoubleClickImplant()
        {
            CrewBox crewBox = new CrewBox();

            crewBox.ImplantDoubleClicked += CrewImplantReceiver;

            for (int index = 0; index < 5; index++)
            {
                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant0_MouseDoubleClick", null, null);
                Assert.AreEqual(index, CrewIndex, "Implant index args do not match");

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant1_MouseDoubleClick", null, null);
                Assert.AreEqual(index, CrewIndex, "Implant index args do not match");

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant2_MouseDoubleClick", null, null);
                Assert.AreEqual(index, CrewIndex, "Implant index args do not match");
            }
        }
    }
}
