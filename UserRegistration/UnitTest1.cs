using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationProject;

namespace UserRegistration
{
    [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestFirstname_ReturnTrue()
            {
                string excepted = "true";
                var actual = UserRegister.ValidateFirstName("Kiran");
                Assert.AreEqual(excepted, actual);
            }
            [TestMethod]
            public void TestFirstname_ReturnFalse()
            {
                string excepted = "false";
                var actual = UserRegister.ValidateFirstName("Ki");
                Assert.AreEqual(excepted, actual);
                var actual1 = UserRegister.ValidateFirstName("kiran");
                Assert.AreEqual(excepted, actual1);

            }
        }
    
}
