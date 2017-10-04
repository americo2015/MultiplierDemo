using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LastNumberLib;

namespace LastNumberTestLab
{
    [TestClass]
    public class LastNumberTest
    {
        [TestMethod]
        public void GetSum()
        {
            var sut = new LastNumber();
            sut.Process("740529345");
            var expected = "2";
            Assert.AreEqual(expected, sut.LastDigit);
        }
    }
}



