using FS_Crew_Config_Tool.Classes.ConfigManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing.TestData;

namespace UnitTests.ConfigManagement.CrewParser_cs
{
    [TestClass]
    public class ParseCrewMemberSection
    {
        [TestMethod]
        public void StripCrewFromRawLineWithNoCrewMembers()
        {
            string expected = "(),(),(),(),()";
            string result = CrewParser.StripCrewFromRawLine("CrewTeams=(ID=\"C3ED77E04FCB6D1876D4F2AFD372E00E\",Name=\"The Opportunists\",Icon=\"\",CrewMembers=((),(),(),(),()),Members=)");

            Assert.AreEqual(expected, result, "Empty roster string does not match");
        }

        [TestMethod]
        public void StripCrewFromRawLineWithFiveCrewMembersNoImplants()
        {
            string expected = RawStringData.FIVE_MEMBERS_NO_IMPLANTS;
            string result = CrewParser.StripCrewFromRawLine(RawStringData.FIVE_MEMBERS_NO_IMPLANTS_FULL_STRING);

            Assert.AreEqual(expected, result, "Full roster string does not match");
        }
    }
}
