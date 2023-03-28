using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;


namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestTask3
    {
        [TestMethod]
        public void Given1_Returns1()
        {
            int givenNumber = 1;
            int expected = 1;

            int actual = Task3.DigitalRoot(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given16_Return7()
        {
            int givenNumber = 16;
            int expected = 7;

            int actual = Task3.DigitalRoot(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given493193_Returns2()
        {
            int givenNumber = 493193;
            int expected = 2;

            int actual = Task3.DigitalRoot(givenNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}
