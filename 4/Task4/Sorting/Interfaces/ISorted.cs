using System.Collections.Generic;

namespace Task4.Sorting.Interfaces
{
    public interface ISorted<T>
    {
        public void Sort(List<T> list, IComparer<T> comparer);
    }
}