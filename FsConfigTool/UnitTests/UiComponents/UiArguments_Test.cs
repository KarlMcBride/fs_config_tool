using FS_Config_Tool.UiComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.UiComponents
{
    [TestClass]
    public class UiArguments_Test
    {
        [TestMethod]
        public void Crew_ValidArgsLowerBounds()
        {
            int expectedCrew = 0;

            CrewArgs args = new CrewArgs(expectedCrew);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Crew index doesn't match");
        }

        [TestMethod]
        public void Crew_ValidArgsUpperBounds()
        {
            int expectedCrew = 4;

            CrewArgs args = new CrewArgs(expectedCrew);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Crew index doesn't match");
        }

        [TestMethod]
        public void Crew_Negative()
        {
            int expectedCrew = -1;
            int erroneousCrew = -2;

            CrewArgs args = new CrewArgs(erroneousCrew);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Negative crew index not correctly handled");
        }

        [TestMethod]
        public void Crew_OOR()
        {
            int expectedCrew = -1;
            int erroneousCrew = 5;

            CrewArgs args = new CrewArgs(erroneousCrew);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "OOR crew index not correctly handled");
        }

        [TestMethod]
        public void CrewImplant_ValidArgsLowerBounds()
        {
            int expectedCrew = 0;
            int expectedImplant = 0;

            CrewImplantArgs args = new CrewImplantArgs(expectedCrew, expectedImplant);

            Assert.AreEqual(expectedCrew, args.CrewIndex,       "Crew index doesn't match");
            Assert.AreEqual(expectedImplant, args.ImplantIndex, "Implant doesn't match");
        }

        [TestMethod]
        public void CrewImplant_ValidArgsUpperBounds()
        {
            int expectedCrew = 4;
            int expectedImplant = 2;

            CrewImplantArgs args = new CrewImplantArgs(expectedCrew, expectedImplant);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Crew index doesn't match");
            Assert.AreEqual(expectedImplant, args.ImplantIndex, "Implant doesn't match");
        }

        [TestMethod]
        public void CrewImplant_NegativeCrew()
        {
            int expectedCrew = -1;
            int erroneousCrew = -2;

            CrewImplantArgs args = new CrewImplantArgs(erroneousCrew, 0);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "Negative crew index not correctly handled");
        }

        [TestMethod]
        public void CrewImplant_OorCrew()
        {
            int expectedCrew = -1;
            int erroneousCrew = 5;

            CrewImplantArgs args = new CrewImplantArgs(erroneousCrew, 0);

            Assert.AreEqual(expectedCrew, args.CrewIndex, "OOR crew index not correctly handled");
        }

        [TestMethod]
        public void CrewImplant_NegativeImplant()
        {
            int expectedImplant = -1;
            int erroneousImplant = -2;

            CrewImplantArgs args = new CrewImplantArgs(0, erroneousImplant);

            Assert.AreEqual(expectedImplant, args.ImplantIndex, "Negative implant index not correctly handled");
        }

        [TestMethod]
        public void CrewImplant_OorImplant()
        {
            int expectedImplant = -1;
            int erroneousImplant = 3;

            CrewImplantArgs args = new CrewImplantArgs(0, erroneousImplant);

            Assert.AreEqual(expectedImplant, args.ImplantIndex, "OOR implant index not correctly handled");
        }
    }
}
