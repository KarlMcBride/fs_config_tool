using FS_Config_Tool;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Listings
{
    [TestClass]
    public class Crew_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
        }

        [TestMethod]
        public void VerifyNoneCrewTypeIsHandled()
        {
            CrewMember noneCrewMember = new CrewMember(CrewEnum.END_OF_LIST, "EOL", CrewRole.END_OF_LIST, "NO CODE");
        }

        [TestMethod]
        public void VerifyCrewCountsMatch()
        {
            int enum_expected = (int)CrewEnum.END_OF_LIST;

            int actual = CrewList.CrewListing.Count;

            Assert.AreEqual(enum_expected, actual);
        }

        [TestMethod]
        public void VerifyCrewListOrder()
        {
            for (int index = 0; index < (int)CrewEnum.END_OF_LIST; index++)
            {
                CrewEnum expected = (CrewEnum)index;

                CrewEnum actual = CrewList.CrewListing[index].CharacterID;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
