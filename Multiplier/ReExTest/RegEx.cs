using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace ReExTest
{
    [TestClass]
    public class RegEx
    {
        [TestMethod]
        public void Russin()
        {
            string pattern = @"\""?([^\""""]*)\""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            Match m = Regex.Match(input, pattern);

            Assert.AreEqual("Mattias Asplund", m.Groups[1].Value);
            Assert.AreEqual("46", m.Groups[2].Value);
            Assert.AreEqual("35000.00", m.Groups[3].Value);
            Assert.AreEqual("070-6186120", m.Groups[4].Value);

        }
    }
}
