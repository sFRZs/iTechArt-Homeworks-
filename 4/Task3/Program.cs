using Bogus;
using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void DeletePerson(LinkedList<string> list)
        {
            var person = list.First;
            var person1 = person;
            var count = 0;
            
            while (list.Count != 1)
            {
                var j = list.Count;
                for (int i = 0; i < j; i++)
                {
                    if (person != null)
                    {
                        person1 = person;
                        person = person.Next;

                        if (i % 2 != 0)
                        {
                            list.Remove(person1);
                        }
                    }

                    else
                    {
                        break;
                    }
                }

                person = list.First;
                count++;

                Console.Write($"\nAfter {count} circle, list: ");
                foreach (var item in list)
                {
                    Console.Write($"{item}. ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var listA = new LinkedList<string>();
            var faker = new Faker();

            Console.Write("Enter the number of people in th circle: ");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N < 2 || N > 100)
            {
                Console.Write("\nError! Please, enter the number of of people in range [2, 100]:");
                N = Convert.ToInt32(Console.ReadLine());
            }

            listA.AddFirst(faker.Person.FirstName);
            for (int i = 1; i < N; i++)
            {
                var faker1 = new Faker();
                if (listA.Last != null)
                {
                    listA.AddAfter(listA.Last, faker1.Person.FirstName);
                }
            }

            Console.Write("listA: ");
            foreach (var item in listA)
            {
                Console.Write($"{item}. ");
            }

            Console.WriteLine();
            DeletePerson(listA);
        }
    }
}