using System.Collections.Generic;

namespace Ventus
{
    internal class Reverse : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}