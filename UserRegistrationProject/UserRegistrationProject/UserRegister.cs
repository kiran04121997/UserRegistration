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
        public static string emailPattern = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@]([a-z]{3,})+([.][a-z]{2,3})*$";
        public static string mobilePattern = "^([9][1])[ ]*[6-9]{1}[0-9]{9}$";
        public static string passwordPattern = "^(?=.*?[0-9])(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[@#$&*.!?]).{8,}";
        public static string sampleEmailPattern = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        //Method to Validate First Name
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
        //Method to Validate Mobile Nuber
        public static string ValidateEmailID(string mail)
        {
            var mailMatch = ValidatePattern(mail, emailPattern);
            return mailMatch;
        }
        //Method to Validate Mobile Nuber
        public static string ValidateMobileNumber(string number)
        {
            var numberMatch = ValidatePattern(number, mobilePattern);
            return numberMatch;
        }
        //Method to Validate Mobile Nuber
        public static string ValidatePassword(string pass)
        {
            var passMatch = ValidatePattern(pass, passwordPattern);
            return passMatch;
        }
        public static void SampleEmail()
        {
            string[] sampleEmail ={"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc-100@abc.net","abc111@abc.com","abc+100@gmail.com",
                                   "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc","abc@.com.my","abc123@gmail.a","abc123@.com",
                                   "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@gmail.com.1a",
                                   "abc@gmail.com.aa.au","abc..2002@gmail.com"};
            Console.WriteLine("Validate Sample Email Id");
            Validate(sampleEmail, sampleEmailPattern);
        }
        public static void Validate(string[] arr, string pattern)
        {
            foreach (var item in arr)
            {
                if (Regex.IsMatch(item, pattern))
                    Console.WriteLine(item + " \t\t " + "Valid Email");
                else
                    Console.WriteLine(item + " \t\t " + "InValid Email");
            }
        }
    }

}
