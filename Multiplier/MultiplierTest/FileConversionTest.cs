using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiplier;

namespace MultiplierTest
{
    [TestClass]
    public class FileConversionTest
    {
        [TestMethod]
        public void amanda_asplund_2003()
        {
            var sut = new FileConversion();
            string actual = sut.Transform("amanda;asplund;2003");
            Assert.AreEqual("AMANDA ASPLUND ÄR 14 ÅR GAMMAL.", actual);
        }
    }
}
