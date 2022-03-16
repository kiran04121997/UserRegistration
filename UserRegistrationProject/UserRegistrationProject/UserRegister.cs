using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProject
{
    public class UserRegister
    {
        // Static Variable
        public static string firstNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string lastNamePattern = "^[A-Z]{1}[a-z]{2}";
        public static string mobilePattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
        public static string passwordPatternR1 = "^[a-zA-Z0-9]{8}";
        //Method to Validate Pattern
        public static string ValidatePattern(string userInput, string pattern)
        {
            if (Regex.IsMatch(userInput, pattern))
                return "true";
            else
                return "false";
        }
        //Method to Validate First Name
        public static string ValidateFirstName(string name)
        {
            var firstNameMatch = ValidatePattern(name, firstNamePattern);
            return firstNameMatch;
        }
        //Method to Validate Last Name
        public static string ValidateLastName(string name)
        {
            var lastNameMatch = ValidatePattern(name, lastNamePattern);
            return lastNameMatch;
        }
        //Method to Validate Mobile Number
        public static string ValidateMobileNumber(string number)
        {
            var numberMatch = ValidatePattern(number, mobilePattern);
            return numberMatch;
        }
        //Method to Validate Password1
        public static string ValidatePassword(string pass)
        {
            var passMatch = ValidatePattern(pass, passwordPatternR1);
            return passMatch;
        }
    }

}
