﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Multiplier;

namespace MultiplierTest
{
    [TestClass]
    public class PurchaseCalculationTests
    {
        [TestMethod]
        public void ExcludedVat()
        {
            var sut = new PurchaseCalculation();
            Multiplier.Multiplier Execute = new Multiplier.Multiplier();

            var total = sut.Execute(10, 100.0M, false);

            Assert.AreEqual(1000.0M, total);
        }

        [TestMethod]
        public void IncludedVat()
        {
            var sut = new PurchaseCalculation();
            var total = sut.Execute(10, 100.0M, true);

            Assert.AreEqual(1250.0M, total);
        }
    }
}
