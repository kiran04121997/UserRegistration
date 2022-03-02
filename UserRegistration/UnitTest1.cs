﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var actual = UserRegister.ValidateFirstName("Ki");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("Kiran");
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
            var actual = UserRegister.ValidateLastName("Bh");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateLastName("bhosale");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("91 9921925459");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        public void TestMobileNumber_ReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateMobileNumber("9921925459");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateMobileNumber("239921925459");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegister.ValidateMobileNumber("91 9921925459");
            Assert.AreEqual(excepted, actual2);
        }
        [TestMethod]
        public void TestPassword_ReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidatePassword("kiran@992192");
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
