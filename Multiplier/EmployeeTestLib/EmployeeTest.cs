using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using EmployeeLib;

namespace EmployeeTestLib
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void Employee()
        {
            

            var sut = new EmployeeConverter();
            sut.Convert("Mattias Asplund 46 35000.00 070-6186120");

            Assert.AreEqual("Asplund, Mattias (Lön: 35000,00 SEK) Telefon:070-6186120 Födelseår:1971", sut.MyString);
        }   
    }
}
