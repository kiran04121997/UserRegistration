using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegistration();
            Console.ReadLine();
        }
        //Method to perform UserRegistration
        public static void UserRegistration()
        {
            /* UC-1-UserRegistration
             * Validate Fisrt Name starts with Cap and have atlest 2 letters.
             */
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(UserRegister.ValidateFirstName(firstName));
        }
    }
}
