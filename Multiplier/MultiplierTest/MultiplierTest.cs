using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTest
{
    [TestClass]
    public class MultiplierTest
    {
        [TestMethod]
        public void Simple()
        {
            //arrange
            Multiplier.Multiplier myMultiplier = new Multiplier.Multiplier();

            var actual = myMultiplier.Simple(20, 20);

            Assert.AreEqual(400, actual);
        }

        [TestMethod]
        public void While()
        {
            //arrange
            Multiplier.Multiplier myMultiplier = new Multiplier.Multiplier();

            var actual = myMultiplier.While(20, 20);

            Assert.AreEqual(400, actual);
        }


    }
}
