using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class Utilities_Test
    {
        [TestMethod]
        public void CheckIfFracIsNotRunning()
        {
            bool result = Utilities.CheckIfFracSpaceIsRunning("Fractured Space");
            Assert.IsFalse(result, "Process didn't return false as expected");
        }

        [TestMethod]
        public void CheckIfFracIsRunning()
        {
            // svchost is a common Win process, and at least one instance will always be running.
            bool result = Utilities.CheckIfFracSpaceIsRunning("svchost");
            Assert.IsTrue(result, "Process didn't return true as expected");
        }

        [TestMethod]
        public void CheckNoneIdForCaptain()
        {
            CrewEnum input = CrewEnum.NONE;

            bool actual = Utilities.IsCrewMemberCaptain(input);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void CheckCaptainsIdForCaptain()
        {
            CrewEnum input = CrewEnum.FRANK_TORRANCE;

            bool actual = Utilities.IsCrewMemberCaptain(input);

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void CheckNonCaptainIdForCaptain()
        {
            CrewEnum input = CrewEnum.SAMUEL_MOSLEY;

            bool actual = Utilities.IsCrewMemberCaptain(input);

            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void ValidateCrewResourceImages()
        {
            for (int index = 0; index < (int)CrewEnum.NONE; index++)
            {
                Bitmap result = Utilities.GetCrewImageByIndex(index);
                Assert.IsNotNull(result, "Image for [" + ((CrewEnum)index).ToString() + "] returned null");
            }
        }

        [TestMethod]
        public void ValidateImplantResourceImages()
        {
            for (int index = 0; index < (int)ImplantEnum.NONE; index++)
            {
                Bitmap result = Utilities.GetImplantImageByIndex(index);
                Assert.IsNotNull(result, "Image for [" + ((ImplantEnum)index).ToString() + "] returned null");
            }
        }

        [TestMethod]
        public void ConvertValidCrewMemberStringsToEnum()
        {
            for (int index = 0; index < (int)CrewEnum.NONE; index++)
            {
                CrewEnum inputCrew = (CrewEnum)index;
                string crewAsString = inputCrew.ToString();

                CrewEnum outputCrew = Utilities.ConvertCrewStringToEnum(crewAsString);

                Assert.AreEqual(inputCrew, outputCrew, "Crew doesn't match, [" + inputCrew + " , " + outputCrew + "]");
            }
        }

        [TestMethod]
        public void ConvertEmptyCrewMemberStringToEnum()
        {
            CrewEnum outputCrew = Utilities.ConvertCrewStringToEnum("");

            Assert.AreEqual(CrewEnum.NONE, outputCrew, "Output is not CrewEnum.None [" + outputCrew + "]");
        }

        [TestMethod]
        public void ConvertInvalidCrewMemberStringToEnum()
        {
            CrewEnum outputCrew = Utilities.ConvertCrewStringToEnum("Invalid crew string");

            Assert.AreEqual(CrewEnum.NONE, outputCrew, "Output for is not CrewEnum.None [" + outputCrew + "]");
        }

        [TestMethod]
        public void GetOnlinePlayerCount()
        {
            string unexpected = "N/A";
            string actual = Utilities.GetOnlinePlayerCount();

            Assert.AreNotEqual(unexpected, actual);
        }
    }
}