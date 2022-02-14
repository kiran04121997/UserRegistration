using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProject
{
    public class Program
    {
        /* UC-4-UserRegistration
         * Validate Mobile Number starts with Country Code and have atlest 1 space after code.
         * and then after country code it should have 10 numbers only.
         */
        //Method to perform UserRegistration
        public static void UserRegistration()
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Choose Option to Validate with their specified Pattern");
                Console.WriteLine("1 = First Name\n2 = Last Name\n3=MobileNumber\n0=Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Continue = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter First Name");
                        string firstName = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateFirstName(firstName));
                        break;
                    case 2:
                        Console.WriteLine("Enter Last Name");
                        string lastName = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateFirstName(lastName));
                        break;
                    case 3:
                        Console.WriteLine("Enter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        Console.WriteLine(UserRegister.ValidateMobileNumber(mobileNumber));
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!");
                        break;
                }
            }
        }
        //Program Entry Point
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            UserRegistration();
            Console.ReadLine();
        }
    }
}
