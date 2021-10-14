using System;

namespace Polymorphism
{
    class Overload
    {
        private string _name = "Akhil";
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload int: {a}");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload string: {a}");
        }
        public void DisplayOverload(string a, int b)
        {
            Console.WriteLine($"DisplayOverload string, int: {a} {b}");
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
        public void Display()
        {
            Display2(ref _name, ref _name);
            Console.WriteLine(_name);
        }

        // <<params>>
        public void Display1()
        {
            DisplayOverload1(28, "OOP", "Zlayay tarelka", "iTechArt");
            DisplayOverload1(30, "params");
            DisplayOverload1(200);

            string[] cars = { "Citroen", "Ford", "BMW", "Nissan" };
            DisplayOverload1(2154, cars);
        }
        private void DisplayOverload1(int a, params string[] parameters)
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

        /* Данный блок кода не имеет смысла и не будет работать, т.к. в данном случае 
        концепция полиморфизма не выполняется. 
         
        public void DisplayOverload() { };
        public int DisplayOverload() { };
        */

        /* Данный блок кода не имеет смысла и не будет работать, т.к. в данном случае 
         модификаторы доступа не являются свойствами, идентифицирующими метод.

        static void DisplayOverload(int a) 
        {
            Console.WriteLine($"DisplayOverload int: {a}");
        }
        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload int: {a}");
        }
        public void DisplayOverload(string a)
        {
            Console.WriteLine($"DisplayOverload string: {a}");
        }
     */

        /* Данный блок кода не имеет смысла и не будет работать, т.к. в данном случае 
         модификаторы параметров не являются свойствами, идентифицирующими метод.

        public void DisplayOverload(int a)
        {
            Console.WriteLine($"DisplayOverload int: {a}");
        }
        private void DisplayOverload(out int a)
       {
            a = 100;
       }
        private void DisplayOverload(ref int a)
       {
           Console.WriteLine($"DisplayOverload int: {a}");
       }
       
    */

        /* Данный блок кода не будет работать, т.к. в данном случае дублируется имя переменной.
        public void DisplayOverload(int a, string a) 
        {
            Console.WriteLine($"DisplayOverload int, string, int: {a} {a}");
        }
        public void DisplayOverload(int a)
        {
            string a = a;
            Console.WriteLine($"DisplayOverload string: {a} ");
        }
        */

        /* Данный метод рабоать не будет, поскольку ключевое слово "params" 
        должно быть пременено только к последнему аргументу.
        public void DisplayOverload1(int a, params string[] parameters, double b) 
        {
            foreach (var str in parameters)
            {
                Console.WriteLine(str + " " + a + " " + b);
            }
        }
        */

        /* Данный блок кода не будет работать, поскольку компилятор не поймёт какой метод использовать.
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
        private void DisplayOverloadInt(int a, params string[] parameters)
        {
             foreach (var str in parameters)
             {
                 Console.WriteLine(str + " " + a);
             }
         }
        */

        /* В данном блоке второй метод рабоать не будет, т. к. массив параметров должен быть одномерным.
        private void DisplayOverload2(int a, params string[][] parameters)
        {
            foreach (var str in parameters)
            {
                Console.WriteLine(str + " " + a);
            }
        }
        private void DisplayOverload2(int a, params string[,] parameters)
        {
            foreach (var str in parameters)
            {
                Console.WriteLine(str + " " + a);
            }
        }
        */
    }
}
