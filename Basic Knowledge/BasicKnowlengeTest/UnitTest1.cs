using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using BasicKnowledge;

namespace BasicKnowlengeTest
{
    [TestClass]
    public class TestTask1
    {
        [TestMethod]
        public void GivenListWithStrings_ReturnsInt()
        {
            List<object> givenList = new List<object>() { 1, 2, 'a', 'b' };
            List<object> expected = new List<object>() { 1, 2 };

            List<object> actual = Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenListOnlyStrings_ReturnsEmpty()
        {
            List<object> givenList = new List<object>() { 'a', 'b' };
            List<object> expected = new List<object>() { };

            List<object> actual = Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenListOnlyInt_ReturnsInt()
        {
            List<object> givenList = new List<object>() { 1, 2 };
            List<object> expected = new List<object>() { 1, 2 };

            List<object> actual = Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
