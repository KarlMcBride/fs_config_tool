using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class Utilities
    {
        [TestMethod]
        public void CheckIfFracIsNotRunning()
        {
            bool result = Utils.CheckIfFracSpaceIsRunning("Fractured Space");
            Assert.IsFalse(result, "Process didn't return false as expected");
        }

        [TestMethod]
        public void CheckIfFracIsRunning()
        {
            // svchost is a common Win process, and at least one instance will always be running.
            bool result = Utils.CheckIfFracSpaceIsRunning("svchost");
            Assert.IsTrue(result, "Process didn't return true as expected");
        }

        [TestMethod]
        public void CheckNoneIdForCaptain()
        {
            CrewEnum input = CrewEnum.NONE;

            bool actual = Utils.IsCrewMemberCaptain(input);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void CheckCaptainsIdForCaptain()
        {
            CrewEnum input = CrewEnum.FRANK_TORRANCE;

            bool actual = Utils.IsCrewMemberCaptain(input);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckNonCaptainIdForCaptain()
        {
            CrewEnum input = CrewEnum.SAMUEL_MOSLEY;

            bool actual = Utils.IsCrewMemberCaptain(input);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateCrewResourceImages()
        {
            for (int index = 0; index < (int)CrewEnum.NONE; index++)
            {
                Bitmap result = Utils.GetCrewImageByIndex(index);
                Assert.IsNotNull(result, "Image for [" + ((CrewEnum)index).ToString() + "] returned null");
            }
        }

        [TestMethod]
        public void ValidateImplantResourceImages()
        {
            for (int index = 0; index < (int)ImplantEnum.NONE; index++)
            {
                Bitmap result = Utils.GetImplantImageByIndex(index);
                Assert.IsNotNull(result, "Image for [" + ((ImplantEnum)index).ToString() + "] returned null");
            }
        }
    }
}