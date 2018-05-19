using FS_Config_Tool.Classes;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTests.TestData;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class CrewSetBox_Test
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

            for(int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
            {
                Assert.IsNotNull(crewSetBox.CheckCrewImageState(index, EXPECTING_IMAGE));
            }
        }

        [TestMethod]
        public void ClearBlankCrew()
        {
            CrewSetBox crewSetBox = new CrewSetBox();
            crewSetBox.ClearDisplayedTeam(null);

            for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
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

            for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
            {
                Assert.IsNotNull(crewSetBox.CheckCrewImageState(index, EXPECTING_NULL));
            }
        }

        [TestMethod]
        public void RemoveClickedCrewMember()
        {
            CrewSetBox crewSetBox = new CrewSetBox();

            crewSetBox.CrewMemberDoubleClicked += CrewReceiver;

            for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
            {
                CrewArgs args = new CrewArgs(index);
                
                crewSetBox.CallHiddenMethod("RemoveClickedCrewMember", null, args);
                Assert.AreEqual(index, ArgCrewIndex, "Crew index args do not match");
            }
        }

        /// <summary>
        /// Ensure that the crew click handler doesn't misbehave if it is null
        /// </summary>
        [TestMethod]
        public void RemoveClickedCrewMember_NoListenerAttached()
        {
            CrewSetBox crewSetBox = new CrewSetBox();

            for (int index = 0; index < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; index++)
            {
                CrewArgs args = new CrewArgs(index);

                crewSetBox.CallHiddenMethod("RemoveClickedCrewMember", null, args);
            }
        }
        [TestMethod]
        public void RemoveClickedImplant()
        {
            CrewSetBox crewSetBox = new CrewSetBox();

            crewSetBox.ImplantDoubleClicked += CrewImplantReceiver;

            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    CrewImplantArgs args = new CrewImplantArgs(crewIndex, implantIndex);

                    crewSetBox.CallHiddenMethod("RemoveClickedImplant", null, args);
                    Assert.AreEqual(crewIndex, ArgCrewIndex, "Crew index args do not match");
                    Assert.AreEqual(implantIndex, ArgImplantIndex, "Implant index args do not match");
                }
            }
        }

        /// <summary>
        /// Ensure that the implant click handler doesn't misbehave if it is null
        /// </summary>
        [TestMethod]
        public void RemoveClickedImplant_NoListenerAttached()
        {
            CrewSetBox crewSetBox = new CrewSetBox();

            for (int crewIndex = 0; crewIndex < TeamConfig.MAX_CREW_MEMBERS_PER_TEAM; crewIndex++)
            {
                for (int implantIndex = 0; implantIndex < TeamConfig.MAX_IMPLANTS_PER_CREW_MEMBER; implantIndex++)
                {
                    CrewImplantArgs args = new CrewImplantArgs(crewIndex, implantIndex);

                    crewSetBox.CallHiddenMethod("RemoveClickedImplant", null, args);
                }
            }
        }
    }
}
