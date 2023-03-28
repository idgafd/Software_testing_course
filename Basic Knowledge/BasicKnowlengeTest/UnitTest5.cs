using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;

namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestTask5
    {
        [TestMethod]
        public void GivenExampleString_Returns()
        {
            string given = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            string actual = Task5.SortGuestList(given);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenAnotherString_Returns()
        {
            string given = "Fred:Borwill;Wilfred:Corwill";
            string expected = "(BORWILL, FRED)(CORWILL, WILFRED)";

            string actual = Task5.SortGuestList(given);
            Assert.AreEqual(expected, actual);
        }
    }
}