using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestsLib
{
    [TestClass]
    public class PracticeTest
    {
        [TestMethod]
        public void ValidateInput()
        {
            var sut = new Practice();

            var actual = sut.FullText("1974-05-29", "Americo", "0760474712");

            Assert.AreEqual("1974-05-29;Americo;0760474712", actual);


        }
    }
}
