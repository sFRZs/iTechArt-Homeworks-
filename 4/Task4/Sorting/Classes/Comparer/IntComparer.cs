using System.Collections.Generic;

namespace Task4.Sorting.Classes.Comparer
{
    public class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}