using System;
using System.Collections.Generic;

namespace Task4.Sorting
{
    public interface ISorted
    {
        public void Sort<T>(List<T> list) where T : IComparable<T>;
    }
}