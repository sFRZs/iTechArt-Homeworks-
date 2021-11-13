using System;

namespace Task1.Exceptions
{
    public class PhoneNotAvailableException : Exception
    {
        public PhoneNotAvailableException()
        {
        }

        public PhoneNotAvailableException(string message) : base(message)
        {
        }
    }
}