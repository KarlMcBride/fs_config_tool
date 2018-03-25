using FS_Crew_Config_Tool.Classes.LineManagement;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.ConfigParsing.Parsing
{
    [TestClass]
    public class ExtractCrewSegment
    {
        [TestMethod]
        public void ExtractRosterWithNoMembers()
        {
            string expected = "(),(),(),(),()";
            string result = Parser.ExtractCrewMemberSection("CrewTeams=(ID=\"C3ED77E04FCB6D1876D4F2AFD372E00E\",Name=\"The Opportunists\",Icon=\"\",CrewMembers=((),(),(),(),()),Members=)");

            Assert.AreEqual(expected, result, "Empty roster string does not match");
        }

        [TestMethod]
        public void ExtractRosterWithFiveMembers()
        {
            string expected = TestData.FIVE_MEMBERS_NO_IMPLANTS;
            string result = Parser.ExtractCrewMemberSection("CrewTeams=(ID=\"C88443774D6346F59F4E1DA8F94529F2\",Name=\"Crew Only\",Icon=\"\",CrewMembers=((ID=\"FFBB0CD044585FA20397788DA4C8361B\"),(ID=\"00CF4ABB4849164394475884CDBD2FA2\"),(ID=\"BA551FBC4960C181F355B980AF657DCE\"),(ID=\"C9E1CF554D3AA9ABBEACC29081923251\"),(ID=\"10D3DC5F47D80063D389A39B9E43C83A\")),Members=)");

            Assert.AreEqual(expected, result, "Full roster string does not match");
        }
    }
}
