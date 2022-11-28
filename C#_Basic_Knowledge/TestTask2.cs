using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Basic_Knowledge;

namespace TestsBasicKnowledge
{
    [TestClass]
    public class TestTask2
    {
        [TestMethod]
        public void FirstNonRepeatingLetter_GivenLowerCaseString_ReturnsT()
        {
            string givenString = new string("stress");
            string expected = new string("t");

            string actual = Basic_Knowledge.Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNonRepeatingLetter_GivenDifferentCaseString_ReturnsT()
        {
            string givenString = new string("sTreSS");
            string expected = new string("T");

            string actual = Basic_Knowledge.Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNonRepeatingLetter_GivenBadString_ReturnsEmpty()
        {
            string givenString = new string("ssTTrReeSS");
            string expected = new string("");

            string actual = Basic_Knowledge.Task2.FirstNonRepeatingLetter(givenString);
            Assert.AreEqual(expected, actual);
        }
    }
}
