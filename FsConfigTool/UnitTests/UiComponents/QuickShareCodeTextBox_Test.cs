using FS_Config_Tool;
using FS_Config_Tool.Classes;
using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class QuickShareCodeTextBox_Test
    {
        [TestMethod]
        public void GenerateCodeWithEmptyCrew()
        {
            TeamConfig team = new TeamConfig();

            QuickShareCodeTextBox codeBox = new QuickShareCodeTextBox();

            codeBox.GenerateCodeFromTeam(team);

            string crewComponent = ((int)CrewEnum.END_OF_LIST).ToString();
            string implantComponent = ((int)ImplantEnum.END_OF_LIST).ToString();
            string memberComponent = crewComponent + "-" + implantComponent + "-" + implantComponent + "-" + implantComponent;

            string expectedResult = string.Empty;
            for (int index = 0; index < 4; index++)
            {
                expectedResult += memberComponent + ",";
            }
            expectedResult += memberComponent;

            Assert.AreEqual(expectedResult, codeBox.Text);
        }

        [TestMethod]
        public void TextChangedToCreateTeam_Empty()
        {
            TeamConfig team = new TeamConfig();

            QuickShareCodeTextBox codeBox = new QuickShareCodeTextBox();

            codeBox.GenerateCodeFromTeam(team);

            string crewComponent = ((int)CrewEnum.END_OF_LIST).ToString();
            string implantComponent = ((int)ImplantEnum.END_OF_LIST).ToString();
            string memberComponent = crewComponent + "-" + implantComponent + "-" + implantComponent + "-" + implantComponent;

            string expectedResult = string.Empty;
            for (int index = 0; index < 4; index++)
            {
                expectedResult += memberComponent + ",";
            }
            expectedResult += memberComponent;

            Assert.AreEqual(expectedResult, codeBox.Text);
        }

        [TestMethod]
        public void TextChangedToCreateTeam_Valid()
        {
            TeamConfig team = new TeamConfig();

            QuickShareCodeTextBox codeBox = new QuickShareCodeTextBox();

            // Paladin max heal / maneuvering crew
            codeBox.Text = "6-9-13-23,27-9-13-23,8-9-13-23,44-9-13-23,68-9-13-23";

            string crewComponent = ((int)CrewEnum.END_OF_LIST).ToString();
            string implantComponent = ((int)ImplantEnum.END_OF_LIST).ToString();
            string memberComponent = crewComponent + "-" + implantComponent + "-" + implantComponent + "-" + implantComponent;

            TeamConfig expectedConfig = TestData.ParsedData.FiveMembersFullImplantsOrdered();

            TeamConfigComparer.VerifyCrewsMatch(expectedConfig, codeBox.GeneratedConfig);
        }

        [TestMethod]
        public void TextChangedToCreateTeam_MissingDelimiters()
        {
            TeamConfig team = new TeamConfig();

            QuickShareCodeTextBox codeBox = new QuickShareCodeTextBox();

            // Paladin max heal / maneuvering crew
            codeBox.Text = "6-9-13-23,27-9-13-23,8-913-23,44-9-13-2368-9-13-23";

            string crewComponent = ((int)CrewEnum.END_OF_LIST).ToString();
            string implantComponent = ((int)ImplantEnum.END_OF_LIST).ToString();
            string memberComponent = crewComponent + "-" + implantComponent + "-" + implantComponent + "-" + implantComponent;
        }

        [TestMethod]
        public void TextChangedToCreateTeam_MissingValues()
        {
            TeamConfig team = new TeamConfig();

            QuickShareCodeTextBox codeBox = new QuickShareCodeTextBox();

            // Paladin max heal / maneuvering crew
            codeBox.Text = "6-9-13-,27-9-13-23,8--13-23,-9-13-23,68-9-13-23";

            string crewComponent = ((int)CrewEnum.END_OF_LIST).ToString();
            string implantComponent = ((int)ImplantEnum.END_OF_LIST).ToString();
            string memberComponent = crewComponent + "-" + implantComponent + "-" + implantComponent + "-" + implantComponent;
        }
    }
}
