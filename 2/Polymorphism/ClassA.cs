using System;

namespace Polymorphism
{
    class ClassA : Override
    {
        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload ClassA: {a} {b}");
        }
        public void Display()
        {
            Display2(ref _name, ref _name);
            Console.WriteLine(_name);
        }
        private void Display2(ref string x, ref string y)
        {
            Console.WriteLine(_name);
            x = "Akhil 1";
            Console.WriteLine(_name);
            y = "Akhil 2";
            Console.WriteLine(_name);
            _name = "Akhil 3";

        }
    }
}
