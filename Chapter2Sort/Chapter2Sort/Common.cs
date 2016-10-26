using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter2Sort
{
    class Common
    {
        public delegate void SortHandler(IComparable[] a);

        public static bool Less(IComparable v, IComparable w)
        {
            return v.CompareTo(w) < 0;
        }

        public static void Exch(IComparable[] a, int i, int j)
        {
            IComparable t = a[i];
            a[i] = a[j];
            a[j] = t;
        }

        public static void Show(IComparable[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
            Console.ReadKey();
        }

        public static bool IsSorted(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
            { 
                if (Less(a[i], a[i - 1]))
                    return false;
            }
            return true;
        }

        public static void Run(IComparable[] a, SortHandler sortMethod)
        {
            if (sortMethod == null)
                throw new ArgumentNullException("sortMethod");
            sortMethod(a);
            Show(a);
            Console.WriteLine("Shorted:" + IsSorted(a).ToString());
        }
    }
}
