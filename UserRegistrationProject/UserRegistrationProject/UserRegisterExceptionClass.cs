using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProject
{

    //class inheriting Base class
    public class UserRegisterExceptionClass : Exception
    {
        public ExceptionType type;
        //Enumeration
        public enum ExceptionType
        {
            EXCEPTION
        }
        //Exception class Constructor.
        public UserRegisterExceptionClass(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
