namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ClassA();
            a.Display1();

            var b = new ClassB();

            /* Данная строка не будет работать, поскольку наследование не работает в обратном порядке 
            (мы не можем в родительском классе использовать методы дочернего класса).
            b.Display2();
            */

            b.Display1();
        }
    }
}
