using System;
using NUnit.Framework;
using TugasLibrary;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void ValidUserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }

        [Test]
        public void NotValidUserTest()
        {
            Assert.IsFalse(user.IsValidUser("salah", "salah"));
            Assert.IsFalse(user.IsValidUser("", ""));
        }
    }
}