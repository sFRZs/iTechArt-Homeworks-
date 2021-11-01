using System;
using System.Collections.Generic;

namespace Task4.Sorting.Classes
{
    public class NumbersSort<T> : ISorted
    {
        public void Sort<T>(List<T> list) where T : IComparable<T>
        {
            GnomeSort(list);
        }

        private void GnomeSort<T>(List<T> list) where T : IComparable<T>
        {
            var i = 1;
            var j = 2;

            while (i < list.Count)
            {
                if (list[i - 1].CompareTo(list[i]) > 0)
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