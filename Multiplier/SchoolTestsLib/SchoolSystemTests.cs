using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTestsLib
{
    [TestClass]
    public class SchoolSystemTests
    {
        [TestMethod]
        public void Count()
        {
            var sut = new SchoolSystem();
            Assert.AreEqual(0, sut.ClassCount);
            Assert.AreEqual(0, sut.StudentCount);
        }
    }
}
