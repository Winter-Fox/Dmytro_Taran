using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Basic_Knowledge;

namespace TestsBasicKnowledge
{
    [TestClass]
    public class TestTask1
    {
        [TestMethod]
        public void GetIntegersFromList_GivenListWithStrings_ReturnsInt()
        {
            List<object> givenList = new List<object>() { 1, 2, 'a', 'b' };
            List<object> expected = new List<object>() { 1, 2 };

            List<object>  actual = Basic_Knowledge.Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntegersFromList_GivenListOnlyStrings_ReturnsEmpty()
        {
            List<object> givenList = new List<object>() {  'a', 'b' };
            List<object> expected = new List<object>() {  };

            List<object> actual = Basic_Knowledge.Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetIntegersFromList_GivenListOnlyInt_ReturnsInt()
        {
            List<object> givenList = new List<object>() { 1, 2 };
            List<object> expected = new List<object>() { 1, 2 };

            List<object> actual = Basic_Knowledge.Task1.GetIntegersFromList(givenList);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
