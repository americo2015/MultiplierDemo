using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoryTellerLib;

namespace StoryTellerTest
{
    [TestClass]
    public class StoryTellerTest
    {
        [TestMethod]
        public void TellStoryToYoungNotScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellSory("Alexander", 6, false);

            Assert.AreEqual($"Lyssna nu Alexander. Det var en gång en prinsessa som tyckte om att dansa.", actual);

        }

        [TestMethod]
        public void TellStoryToOldNotScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellSory("Linda", 8, false);

            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som tyckte om att dansa.", actual);

        }

        [TestMethod]
        public void TellStoryTooScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellSory("Linda", 8, true);

            Assert.AreEqual($"Hallå Linda! En gång fanns en kille som egentligen var en varulv", actual);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TellStoryToYoungScary()
        {
            var sut = new StoryTeller();
            string actual = sut.TellSory("Peter", 4, true);

        }
    }
}
