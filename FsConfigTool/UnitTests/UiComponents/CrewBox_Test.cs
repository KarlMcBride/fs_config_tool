using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewBox_Test
    {
        private int ArgCrewIndex;
        /// <summary>
        /// Helper method for receiving injected crew events
        /// </summary>
        private void CrewReceiver(object sender, CrewArgs e)
        {
            ArgCrewIndex = e.CrewIndex;
        }

        private int ArgImplantIndex;
        /// <summary>
        /// Helper method for receiving injected crew implant events
        /// </summary>
        private void CrewImplantReceiver(object sender, CrewImplantArgs e)
        {
            ArgCrewIndex = e.CrewIndex;
            ArgImplantIndex = e.ImplantIndex;
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
        public void DoubleClickCrew_ListenerAttached()
        {
            CrewBox crewBox = new CrewBox();

            crewBox.CrewMemberDoubleClicked += CrewReceiver;

            for(int index = 0; index < 5; index++)
            {
                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxCrew_MouseDoubleClick", null, null);
                Assert.AreEqual(index, ArgCrewIndex, "Crew index args do not match");
            }
        }

        /// <summary>
        /// Ensure that the crew click handler doesn't misbehave if it is null
        /// </summary>
        [TestMethod]
        public void DoubleClickCrew_NoListenerAttached()
        {
            CrewBox crewBox = new CrewBox();

            for (int index = 0; index < 5; index+=6)
            {
                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxCrew_MouseDoubleClick", null, null);
                Assert.AreEqual(index, ArgCrewIndex, "Crew index args do not match");
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
                Assert.AreEqual(0, ArgImplantIndex, "Implant index args do not match");

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant1_MouseDoubleClick", null, null);
                Assert.AreEqual(1, ArgImplantIndex, "Implant index args do not match");

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant2_MouseDoubleClick", null, null);
                Assert.AreEqual(2, ArgImplantIndex, "Implant index args do not match");
            }
        }

        /// <summary>
        /// Ensure that the implant click handler doesn't misbehave if it is null
        /// </summary>
        [TestMethod]
        public void DoubleClickImplant_NoListenerAttached()
        {
            CrewBox crewBox = new CrewBox();

            for (int index = 0; index < 5; index++)
            {
                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant0_MouseDoubleClick", null, null);

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant1_MouseDoubleClick", null, null);

                crewBox.SetBoxIndex(index);
                crewBox.CallHiddenMethod("PictureBoxImplant2_MouseDoubleClick", null, null);
            }
        }
    }
}
