using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProject
{
        public class Program
        {
            /* UC-2-UserRegistration
             * Validate Last Name starts with Cap and have atlest 3 letters.
             */
            //Method to perform UserRegistration
            public static void UserRegistration()
            {
                bool Continue = true;
                while (Continue)
                {
                    Console.WriteLine("Choose Option");
                    Console.WriteLine("1 = First Name\n2 = Last Name\n0=Exit");
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
                            Console.WriteLine(UserRegister.ValidateLastName(lastName));
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
