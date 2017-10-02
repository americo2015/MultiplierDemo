using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceLib;
using System.Diagnostics;

namespace DiceTestLib
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void Throw_Seven_Wins()
        {
            Random random = new Random();
            var sut = new Game(random);
            while (!sut.IsWinner)
            {
                sut.ThrowDice();
                Debug.WriteLine(sut.ToString());
            }

            Debug.WriteLine($"Won after {sut.ThrowsMade} throws.");
            Assert.AreEqual(7, sut.NumberOfPoints);
        }
    }
}
