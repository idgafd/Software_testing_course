using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;


namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestExtrsTask2
    {
        [TestMethod]
        public void Given0()
        {
            uint givenNumber = 0;
            string expected = "0.0.0.0";

            string actual = ExtraTask2.numberToIPAdress(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Give32()
        {
            uint givenNumber = 32;
            string expected = "0.0.0.32";

            string actual = ExtraTask2.numberToIPAdress(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given2149583361()
        {
            uint givenNumber = 2149583361;
            string expected = "128.32.10.1";

            string actual = ExtraTask2.numberToIPAdress(givenNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}