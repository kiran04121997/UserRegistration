using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProject;

namespace UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName_ReturnTrue")]
        public void GivenFirstNameShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateFirstName("Saurav");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("FirstName_ReturnFalse")]
        public void GivenFirstNameShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Sa");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("saurav");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("LastName_ReturnTrue")]
        public void GivenLastNameShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateLastName("Kumar");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("LastName_ReturnFalse")]
        public void GivenLastNameShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateLastName("Ka");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateLastName("kumar");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("EmailId_ReturnTrue")]
        public void GivenEmailIDshouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateEmailID("saurav@gmail.co.in");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("EmailId_ReturnFalse")]
        public void GivenEmailIDShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateEmailID("saurav.kr@g.in");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateEmailID(".kr@gmail.com.in");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("MobileNumber_ReturnTrue")]
        public void GivenMobileNumberShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("91 7067845485");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("MobileNumber_ReturnFalse")]
        public void GivenMobileNumberShouldReturnFalse()
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
        [TestCategory("Password_ReturnTrue")]
        public void GivenPasswordShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidatePassword("SauGav76@#$");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Password_ReturnFalse")]
        public void GivenPasswordShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidatePassword("S9a@#$j");
            Assert.AreEqual(excepted, actual);
        }
    }
}
