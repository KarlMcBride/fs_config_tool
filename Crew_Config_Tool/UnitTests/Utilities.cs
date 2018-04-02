using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Utilities
    {
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
            CrewEnum input = CrewEnum.SAMUEL_MOSELY;

            bool actual = Utils.IsCrewMemberCaptain(input);

            Assert.AreEqual(false, actual);
        }
    }
}