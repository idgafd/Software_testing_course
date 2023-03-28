using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;

namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestExtraTask1
    {
        [TestMethod]
        public void Given9_ReturnsMinus1()
        {
            int givenNumber = 9;
            int expected = -1;

            int actual = ExtraTask1.ReturnBiggerNumber(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given513_Returns531()
        {
            int givenNumber = 513;
            int expected = 531;

            int actual = ExtraTask1.ReturnBiggerNumber(givenNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given531_ReturnsMinus1()
        {
            int givenNumber = 531;
            int expected = -1;

            int actual = ExtraTask1.ReturnBiggerNumber(givenNumber);
            Assert.AreEqual(expected, actual);
        }

    }
}