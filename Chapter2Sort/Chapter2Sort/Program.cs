using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 6, 4, 2, 3 };
            Common.Run(a.Cast<IComparable>().ToArray(), PrimaryRank.Selection.Sort);
        }
    }
}
