using System.Collections.Generic;

namespace Task4.Sorting.Classes.Comparer
{
    public class StrComparer : IComparer<string>
    {
        public int Compare(string str1, string str2)
        {
            return (str1.Length - str2.Length) * (-1);
        }
    }
}