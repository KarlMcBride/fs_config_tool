using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Listings
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

        [TestMethod]
        public void VerifyGetStat()
        {
            for (int index = 0; index < (int)ImplantEnum.END_OF_LIST; index++)
            {
                StatCombination stat = ImplantList.ImplantListing[index].Stat;

                float expectedFloat = 0;

                Assert.AreNotEqual(StatCategory.END_OF_LIST,    stat.Category, "Category is unassigned");
                Assert.AreNotEqual(string.Empty,                stat.Name,     "Name is unassigned");
                Assert.AreNotEqual(StatEnum.END_OF_LIST,        stat.Type,     "Type is unassigned");
                Assert.AreNotEqual(expectedFloat,               stat.Value,    "Value is unassigned");
            }
        }
    }
}
