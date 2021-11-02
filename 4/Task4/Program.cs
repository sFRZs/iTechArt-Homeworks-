using System;
using System.Collections.Generic;
using Bogus;
using Task4.Sorting.Classes;
using Task4.Sorting.Classes.Comparer;
using Task4.Sorting.Interfaces;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var intList = new List<int>();
            var intList2 = new List<int>();
            var stringList = new List<string>();
            var stringList2 = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                intList.Add(rnd.Next(-100, 101));
                intList2.Add(rnd.Next(-100, 101));

                var faker = new Faker();
                stringList.Add(faker.Hacker.Noun());

                var faker2 = new Faker();
                stringList2.Add(faker2.Hacker.Noun());
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

            Console.Write("Int list №2: ");
            foreach (var i in intList2)
            {
                Console.Write($"{i}. ");
            }

            Console.WriteLine();

            Console.Write("String list№2: ");
            foreach (var str in stringList2)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Sorting.

            ISorted<int> intGnomeSort = new GnomeSort<int>();
            ISorted<string> stringGnomeSort = new GnomeSort<string>();
            ISorted<int> intPancakeSort = new PancakeSort<int>();
            ISorted<string> stringPancakeSort = new PancakeSort<string>();

            intGnomeSort.Sort(intList, new IntComparer());
            stringGnomeSort.Sort(stringList, new StrComparer());

            intPancakeSort.Sort(intList2, new IntComparer());
            stringPancakeSort.Sort(stringList2, new StrComparer());


            Console.Write("Int list, sorted with Gnome Sort: ");
            foreach (var i in intList)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write("String list, sorted with Gnome Sort: ");
            foreach (var str in stringList)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Int list №2, sorted with Pancake Sort: ");
            foreach (var i in intList2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            Console.Write("String list №2, sorted with Pancake Sort: ");
            foreach (var str in stringList2)
            {
                Console.Write($"{str}. ");
            }

            Console.WriteLine();
        }
    }
}