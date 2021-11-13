using System;

namespace Task1.Exceptions
{
    public class PhoneNotFoundException : Exception
    {
        public PhoneNotFoundException()
        {
        }

        public PhoneNotFoundException(string message) : base(message)
        {
        }
    }
}