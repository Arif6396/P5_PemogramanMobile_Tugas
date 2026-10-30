using System;
using NUnit.Framework;
using TugasLibrary; 

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class DayTest
    {
        private Day day;

        [SetUp]
        public void Init()
        {
            day = new Day();
        }

        [Test]
        public void ValidDayTest()
        {
            Assert.AreEqual("Senin", day.NameOfDay(1));
            Assert.AreEqual("Selasa", day.NameOfDay(2));
        }

        [Test]
        public void NotValidDayTest()
        {
            Assert.IsEmpty(day.NameOfDay(8));
            Assert.IsEmpty(day.NameOfDay(0));
        }
    }
}