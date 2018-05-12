using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using FS_Crew_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ListingChecks
{
    [TestClass]
    public class Implant_Test
    {
        [TestInitialize]
        public void PopulateLists()
        {
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void VerifyImplantCountsMatch()
        {
            int enum_expected = (int)ImplantEnum.END_OF_LIST;

            int actual = ImplantList.ImplantListing.Count;

            Assert.AreEqual(enum_expected, actual);
        }

        [TestMethod]
        public void VerifyImplantListOrder()
        {
            for (int index = 0; index < (int)ImplantEnum.END_OF_LIST; index++)
            {
                ImplantEnum expected = (ImplantEnum)index;

                ImplantEnum actual = ImplantList.ImplantListing[index].ID;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
