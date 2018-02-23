using System;
using System.Collections.Generic;

namespace FirstDuplicate
{
    class Program
    {
        public static int FirstDuplicate(int[] a)
        {

            HashSet<int> set = new HashSet<int>();

            for(var i = 0; i <= a.Length - 1; i++)
            {
                if (set.Contains(a[i]))
                {
                    return a[i];
                }

                set.Add(a[i]);
            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = {2, 3, 3, 1, 5, 2};
            Console.Write(FirstDuplicate(arr));
            Console.ReadLine();

        }
    }
}
