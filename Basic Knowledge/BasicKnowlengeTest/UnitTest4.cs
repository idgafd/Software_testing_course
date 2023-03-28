using Microsoft.VisualStudio.TestTools.UnitTesting;

using BasicKnowledge;

namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestTask4
    {
        [TestMethod]
        public void Given1235_5_Returns2()
        {
            int[] givenArr = new int[] { 1, 2, 3, 4, 5 };
            int givenTarget = 5;
            int expected = 2;

            int actual = Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given11111_2_Returns10()
        {
            int[] givenArr = new int[] { 1, 1, 1, 1, 1 };
            int givenTarget = 2;
            int expected = 10;

            int actual = Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given12344_5_Returns3()
        {
            int[] givenArr = new int[] { 1, 2, 3, 4, 4 };
            int givenTarget = 5;
            int expected = 3;

            int actual = Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }
    }
}
