using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2Sort.PrimaryRank
{
    class Selection
    {
        public static void Sort(IComparable[] a)
        {
            int N = a.Length;
            for (int i = 0; i < N; i++)
            {
                int min = i;
                for (int j = i + 1; j < N; j++)
                {
                    if (Common.Less(a[j], a[min]))
                        min = j;
                    Common.Exch(a, i, min);
                }
            }
        }
    }
}
