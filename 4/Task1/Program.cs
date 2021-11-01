using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var plentyA = new Stack<int>();
            var plentyB = new Stack<int>();
            var plentyC = new Stack<int>();

            int[] arrayA = new[] {38, 418, 528, 956, 296, 540, 657, 575, 429, 361};
            int[] arrayB = new[] {570, 575, 266, 296, 793, 792, 409, 38, 480, 515};

            for (int i = 0; i < arrayA.Length; i++)
            {
                plentyA.Push(arrayA[i]);
                plentyB.Push(arrayB[i]);
            }

            foreach (var item in plentyA)
            {
                if (plentyB.Contains(item))
                {
                    plentyC.Push(item);
                }
            }

            Console.Write("plentyC: ");
            foreach (var item in plentyC)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}