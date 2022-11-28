using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Basic_Knowledge;

namespace TestsBasicKnowledge
{
    [TestClass]
    public class TestTask5
    {
        [TestMethod]
        public void SortGuestList_GivenExampleString_ReturnsRightAnswer()
        {
            string given = "Fred:Corwill;Wilfred:Corwill;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            string actual = Basic_Knowledge.Task5.SortGuestList(given);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortGuestList_GivenLittle_ReturnsRightAnswer()
        {
            string given = "Fred:Borwill;Wilfred:Corwill";
            string expected = "(BORWILL, FRED)(CORWILL, WILFRED)";

            string actual = Basic_Knowledge.Task5.SortGuestList(given);
            Assert.AreEqual(expected, actual);
        }
    }
}
