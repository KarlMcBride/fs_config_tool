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

            codeBox.GenerateCode(team);

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

            codeBox.GenerateCode(team);

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
    }
}
