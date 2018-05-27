using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.Classes.Listings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTestCore
    {
        [TestInitialize]
        public void PopulateLists()
        {
            StatList.PopulateStatsList();
            CrewList.PopulateCrewList();
            ImplantList.PopulateImplantList();
            ShipList.PopulateShipList();
        }
    }
}
