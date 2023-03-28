using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;

namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestTask2
    {
        [TestMethod]
        public void GivenLowerCase_Returnst()
        {
            string givenString = "stress";
            string expected = "t";

            string actual = Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenLowerAndUpperCase_ReturnsT()
        {
            string givenString = "sTreSs";
            string expected = "T";

            string actual = Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenRepeatingLetters_ReturnsEmpty()
        {
            string givenString = "sTtrReESs";
            string expected = "";

            string actual = Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }
    }
}
