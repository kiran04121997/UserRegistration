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
            //Method to Validate First Name
            public static string ValidateFirstName(string name)
            {
                if (Regex.IsMatch(name, firstNamePattern))
                    return "true";
                else
                    return "false";
            }
        }
    
}
