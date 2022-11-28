using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Basic_Knowledge;

namespace TestsBasicKnowledge
{
    [TestClass]
    public class TestTask4
    {
        [TestMethod]
        public void FindTargetSum_Given12345_And5_Returns2()
        {
            int[] givenArr = new int[] { 1, 2, 3, 4, 5 };
            int givenTarget = 5;
            int expected = 2;

            int actual = Basic_Knowledge.Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindTargetSum_Given11111_And2_Returns10()
        {
            int[] givenArr = new int[] { 1, 1, 1, 1, 1 };
            int givenTarget = 2;
            int expected = 10;

            int actual = Basic_Knowledge.Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindTargetSum_Given11111_And3_Returns0()
        {
            int[] givenArr = new int[] { 1, 1, 1, 1, 1 };
            int givenTarget = 3;
            int expected = 0;

            int actual = Basic_Knowledge.Task4.FindTargetSum(givenArr, givenTarget);
            Assert.AreEqual(expected, actual);
        }
    }
}
