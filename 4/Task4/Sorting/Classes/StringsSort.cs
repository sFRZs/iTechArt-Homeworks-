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
            for (int i = list.Count - 1; i >= 0; i--)
            {
                var indexOfMax = IndexOfMaxElement(list, i);
                if (indexOfMax != i)
                {
                    Flip(list, indexOfMax);
                    Flip(list, i);
                }
            }
        }

        private int IndexOfMaxElement<T>(List<T> list, int end)
        {
            var result = 0;
            for (int i = 1; i <= end; i++)
            {
                string previusStr = list[result] as string;
                string str = list[i] as string;
                if (str != null && previusStr != null && previusStr.Length < str.Length)
                {
                    result = i;
                }
            }

            return result;
        }

        private void Flip<T>(List<T> list, int endElement)
        {
            for (int i = 0; i < endElement; i++, endElement--)
            {
                T tmp = list[i];
                list[i] = list[endElement];
                list[endElement] = tmp;
            }
        }
    }
}