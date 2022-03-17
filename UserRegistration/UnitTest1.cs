using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProject;

namespace UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateFirstName("Kiran");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestFirstName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Ka");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("kiran");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestLastName_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateLastName("Bhosale");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestLastName_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateLastName("bh");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateLastName("bhosale");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("+91-7067845485");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateMobileNumber("7067845485");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateMobileNumber("23 7067845485");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegister.ValidateMobileNumber("91 70678454858");
            Assert.AreEqual(excepted, actual2);
        }
        [TestMethod]
        public void TestPassword_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidatePassword("Kiran9921");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestPassword_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidatePassword("K9a@#$j");
            Assert.AreEqual(excepted, actual);
        }
    }
}
