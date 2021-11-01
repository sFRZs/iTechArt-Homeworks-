using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static public int SumOfElements(Queue<int> q)
        {
            var sum = 0;
            var listA = new List<int>();

            foreach (var item in q)
            {
                listA.Add(item);
            }

            // In these variables we store the index of the minimum and maximum elements. 
            var min = 0;
            var max = 0;

            for (int i = 1; i < listA.Count; i++)
            {
                if (listA[i] < listA[min])
                {
                    min = i;
                }

                if (listA[i] > listA[max])
                {
                    max = i;
                }
            }

            // Choose which index to start sum cycles from.

            var k = 0;
            var j = 0;

            if (min < max)
            {
                k = min;
                j = max;
            }

            else
            {
                k = max;
                j = min;
            }

            // Counting the sum of the elements.

            for (; k <= j; k++)
            {
                sum += listA[k];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Random rnd = new Random();

            Console.Write("Enter number of the elements of queue: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N <= 0 || N > 50)
            {
                Console.Write("\nError! Please, enter number of the elements of queue in range (1, 50):");
                N = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(rnd.Next(-100, 101));
            }

            Console.Write("queue: ");
            foreach (var item in queue)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            int sum = SumOfElements(queue);
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
