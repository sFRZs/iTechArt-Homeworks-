using System.Collections.Generic;
using Task4.Sorting.Interfaces;

namespace Task4.Sorting.Classes
{
    public class GnomeSort<T> : ISorted<T>
    {
        public void Sort(List<T> list, IComparer<T> comparer)
        {
            var i = 1;
            var j = 2;

            while (i < list.Count)
            {
                if (comparer.Compare(list[i - 1], list[i]) > 0)
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

        private void Swap(List<T> list, int i, int j)
        {
            T tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }
    }
}