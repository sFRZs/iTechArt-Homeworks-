using System;

namespace Polymorphism
{
    class ParentClass
    {
        protected string _name = "Akhil";


        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload int: {a}");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload string: {a}");
        }

        public void DisplayOverloadInt(int a, int b, int c)
        {
            Console.WriteLine($"DisplayOverloadIntnt: {a}, {b}, {c}");
        }
    }
}
