using System;
using FS_Crew_Config_Tool;
using FS_Crew_Config_Tool.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ListingChecks
{
    [TestClass]
    public class CrewAndImplants
    {
        [TestInitialize]
        public void PopulateLists()
        {
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
        }

        [TestMethod]
        public void VerifyCrewCountsMatch()
        {
            int enum_expected = (int)CrewEnum.NONE;

            int actual = CrewList.CrewListing.Count;

            Assert.AreEqual(enum_expected, actual);
        }

        [TestMethod]
        public void VerifyImplantCountsMatch()
        {
            int enum_expected = (int)ImplantEnum.NONE;

            int actual = ImplantList.ImplantListing.Count;

            Assert.AreEqual(enum_expected, actual);
        }

        [TestMethod]
        public void VerifyImplantListOrder()
        {
            for (int index = 0; index < (int)ImplantEnum.NONE; index++)
            {
                ImplantEnum expected = (ImplantEnum)index;

                ImplantEnum actual = ImplantList.ImplantListing[index].ID;

                Assert.AreEqual(expected, actual);
            }

        }
    }
}
