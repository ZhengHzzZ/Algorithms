using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2Sort.PrimaryRank
{
    class Insertion
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 1; i < N; i++)
            {
                for (int j = i; j > 0 && Common.Less(a[j], a[j - 1]); j--)
                {
                    Common.Exch(a, j, j - 1);
                }
            }
        }
    }
}
