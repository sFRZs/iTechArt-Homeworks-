using System;
using System.Collections.Generic;

namespace Task4.Sorting.Classes
{
    public class StringsSort : ISorted
    {
        public void Sort<T>(List<T> list) where T : IComparable<T>
        {
            PancakeSort(list);
        }

        private void PancakeSort<T>(List<T> list) where T : IComparable<T>
        {
            var i = 1;
            var j = 2;

            while (i < list.Count)
            {
                string previusStr = list[i - 1] as string;
                string str = list[i] as string;
                if (previusStr != null && previusStr.Length < str.Length)
                {
                    i = j;
                    j++;
                }
                else
                {
                    Swap(list, i - 1, i);
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
        }

        private void Swap<T>(List<T> list, int i, int j)
        {
            T tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }
    }
}