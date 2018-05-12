using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ListingChecks
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
