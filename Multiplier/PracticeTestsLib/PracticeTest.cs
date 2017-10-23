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

            var actual = sut.FullText("1974-05-29", "Americo", "1234567");

            Assert.AreEqual("1974-05-29;Americo;1234567", actual);


        }

        [TestMethod]
        public void TransformInput()
        {
            var sut = new Practice();

            var actual = sut.Transformation("1974-05-29;Americo;1234567");

            Assert.AreEqual("Americo är 43 år gammal och har telfonnummer 1234567", actual);


        }
    }
}
