using System;
using System.Collections.Generic;
using Bogus;
using Task4.Sorting.Classes;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var intList = new List<int>();
            var stringList = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                intList.Add(rnd.Next(-100, 101));

                var faker = new Faker();
                stringList.Add(faker.Hacker.Noun());
            }

            Console.Write("Int list: ");
            foreach (var i in intList)
            {
                Console.Write($"{i}. ");
            }

            Console.WriteLine();

            Console.Write("String list: ");
            foreach (var str in stringList)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();

            var numbersSort = new NumbersSort<int>();
            var stringsSort = new StringsSort();

            numbersSort.Sort(intList);
            stringsSort.Sort(stringList);

            Console.Write("Int list: ");
            foreach (var i in intList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write("String list: ");
            foreach (var str in stringList)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
        }
    }
}