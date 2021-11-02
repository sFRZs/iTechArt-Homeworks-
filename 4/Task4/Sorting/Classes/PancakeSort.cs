using System.Collections.Generic;
using Task4.Sorting.Interfaces;

namespace Task4.Sorting.Classes
{
    public class PancakeSort<T> : ISorted<T>
    {
        public void Sort(List<T> list, IComparer<T> comparer)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                var indexOfMax = IndexOfMaxElement(list, i, comparer);
                if (indexOfMax != i)
                {
                    Flip(list, indexOfMax);
                    Flip(list, i);
                }
            }
        }

        private int IndexOfMaxElement(List<T> list, int end, IComparer<T> comparer)
        {
            var result = 0;
            for (int i = 1; i <= end; i++)
            {
                if (comparer.Compare(list[i], list[result]) < 0)
                {
                    result = i;
                }
            }

            return result;
        }

        private void Flip(List<T> list, int endElement)
        {
            for (int i = 0; i <= endElement; i++, endElement--)
            {
                T tmp = list[i];
                list[i] = list[endElement];
                list[endElement] = tmp;
            }
        }
    }
}