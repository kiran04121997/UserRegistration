using System;
using System.Runtime.Serialization;

namespace UserRegistrationProject
{
    [Serializable]
    internal class UserRegisterException : Exception
    {
        private object eXCEPTION;
        private string v;

        public UserRegisterException()
        {
        }

        public UserRegisterException(string message) : base(message)
        {
        }

        public UserRegisterException(object eXCEPTION, string v)
        {
            this.eXCEPTION = eXCEPTION;
            this.v = v;
        }

        public UserRegisterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserRegisterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}