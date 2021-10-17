using System;

namespace Polymorphism
{
    class ClassB : Override
    {
        public void Display()
        {
            DisplayOverload(28, "OOP", "Zlayay tarelka", "iTechArt", "\n");
            DisplayOverload(30, "params");
            DisplayOverload(200);

            string[] cars = { "Citroen", "Ford", "BMW", "Nissan", "\n" };
            DisplayOverload(2154, cars);
        }
        private void DisplayOverload(int a, params string[] parameters)
        {
            foreach (var str in parameters)
            {
                Console.WriteLine(str + " " + a);
            }
        }

        public void DisplayInt()
        {
            DisplayOverloadInt(100, 200, 300);
            DisplayOverloadInt(28, 29);
            DisplayOverloadInt(1);
        }
        private void DisplayOverloadInt(int a, params int[] parameters)
        {
            foreach (var item in parameters)
            {
                Console.WriteLine(item + " " + a);
            }
        }
    }
}
