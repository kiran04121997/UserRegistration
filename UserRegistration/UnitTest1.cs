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
            var actual = UserRegister.ValidateFirstName("Kiran");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("FirstName_ReturnFalse")]
        public void GivenFirstNameShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateFirstName("Ki");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateFirstName("kiran");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("LastName_ReturnTrue")]
        public void GivenLastNameShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateLastName("Bhosale");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("LastName_ReturnFalse")]
        public void GivenLastNameShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateLastName("Bh");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateLastName("Bhosale");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("EmailId_ReturnTrue")]
        public void GivenEmailIDshouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateEmailID("bhosalekiran259@gmail.com");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("EmailId_ReturnFalse")]
        public void GivenEmailIDShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateEmailID("kiran.kr@g.in");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateEmailID(".kiran@gmail.com.in");
            Assert.AreEqual(excepted, actual1);
        }
        [TestMethod]
        [TestCategory("MobileNumber_ReturnTrue")]
        public void GivenMobileNumberShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidateMobileNumber("91 9921925459");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("MobileNumber_ReturnFalse")]
        public void GivenMobileNumberShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidateMobileNumber("9921925459");
            Assert.AreEqual(excepted, actual);
            var actual1 = UserRegister.ValidateMobileNumber("23 9921925459");
            Assert.AreEqual(excepted, actual1);
            var actual2 = UserRegister.ValidateMobileNumber("91 9921925459");
            Assert.AreEqual(excepted, actual2);
        }
        [TestMethod]
        [TestCategory("Password_ReturnTrue")]
        public void GivenPasswordShouldReturnTrue()
        {
            string excepted = "true";
            var actual = UserRegister.ValidatePassword("kiran@992192");
            Assert.AreEqual(excepted, actual);
        }
        [TestMethod]
        [TestCategory("Password_ReturnFalse")]
        public void GivenPasswordShouldReturnFalse()
        {
            string excepted = "false";
            var actual = UserRegister.ValidatePassword("K9a@#$j");
            Assert.AreEqual(excepted, actual);
        }
    }
}
