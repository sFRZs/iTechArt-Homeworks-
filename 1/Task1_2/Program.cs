using System;

namespace Task1_2
{
    class Program1_2
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = ++a;
            var c = a + b * a--;
            b = c != 50 ? 50 / a - 1 : c % 50;

            bool answer = false;
            bool answer2 = (b >= 60) ^ (c <= 48);

            if ((b > 0 & c <= 50) || c % 2 == 0)
            {
                answer = true;

            }

            if ((c * c > 25) && answer)
            {
                Console.WriteLine(c * b);
            }

            if (Console.CapsLock | Console.NumberLock)
            {
                Console.WriteLine("On");
            }



            object d = b + 10;

            if (d is int x)
            {
                Console.WriteLine(x + a - c);
            }


            string str = d as string;
            Console.WriteLine(str);

        }
    }
}
