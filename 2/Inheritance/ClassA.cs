using System;

namespace Inheritance
{
    class ClassA : ClassB
    {
        public void Display1()
        {
            Console.WriteLine("ClassA Display1" + " " + x);

            // Ключевое слово "base" исп. для обращения к методу родительского класса.
            base.Display1();
        }
        public void Display2()
        {
            Console.WriteLine("ClassA Display2");
        }
    }
}
