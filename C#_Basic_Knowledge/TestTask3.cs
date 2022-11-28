using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Basic_Knowledge;

namespace TestsBasicKnowledge
{
    [TestClass]
    public class TestTask3
    {
        [TestMethod]
        public void DigitalRoot_Given123_Returns6()
        {
            int given = 123;
            int expected = 6;

            int actual = Basic_Knowledge.Task3.DigitalRoot(given);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DigitalRoot_Given1_Returns1()
        {
            int given = 1;
            int expected = 1;

            int actual = Basic_Knowledge.Task3.DigitalRoot(given);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DigitalRoot_Given12345_Returns6()
        {
            int given = 12345;
            int expected = 6;

            int actual = Basic_Knowledge.Task3.DigitalRoot(given);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DigitalRoot_Given493193_Returns2()
        {
            int given = 493193;
            int expected = 2;

            int actual = Basic_Knowledge.Task3.DigitalRoot(given);
            Assert.AreEqual(expected, actual);
        }
    }
}
