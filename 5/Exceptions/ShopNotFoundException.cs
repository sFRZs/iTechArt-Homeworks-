using System;

namespace Task1.Exceptions
{
    public class ShopNotFoundException : Exception
    {
        public ShopNotFoundException()
        {
        }

        public ShopNotFoundException(string message) : base(message)
        {
        }
    }
}