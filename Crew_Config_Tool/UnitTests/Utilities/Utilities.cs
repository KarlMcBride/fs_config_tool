using System;
using FS_Crew_Config_Tool.Classes.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTests.ConfigParsing;

namespace UnitTests.Utilities
{
    [TestClass]
    public class Utilities
    {
        [TestMethod]
        public void ReplaceBracketsWithChevrons_Valid()
        {
            string testString = "((Chevron Test )()";

            ConfigUtilities.SubstituteBracketsForChevrons(ref testString);

            Assert.AreEqual("<<Chevron Test ><>", testString);
        }
    }
}
