using System;
using System.Collections.Generic;


namespace Task11
{
    public class SomeLogic
    {
        public bool IsNumberLessThen10(int number)
        {
            if (number >= 10)
            {
                return false;
            }

            return true;
        }

        public double GetHipotenuseOfRightTriangle(int firstSide, int secondSide)
        {
            return Math.Round(Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2)), 3);
        }

        public string GenerateSomeString(char character, int minLength, int maxLength)
        {
            var rnd = new Random();
            int length = rnd.Next(minLength, maxLength + 1);
            return new string(character, length);
        }

        // public List<int> GenerateSomeList(int countElements, int minValue, int maxValue)
        // {
        //     var list = new List<int>();
        //     var rnd = new Random();
        //
        //     for (int i = 0; i < countElements; i++)
        //     {
        //         list.Add(rnd.Next(minValue, maxValue + 1));
        //     }
        //
        //     return list;
        // }

        public void GenerateArgumentException()
        {
            throw new ArgumentException();
        }

        public int[] GetArrayWithNumbersSquared(int[] inputArray)
        {
            int[] outArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                outArray[i] = (int) Math.Pow(inputArray[i], 2);
            }

            return outArray;
        }
    }
}