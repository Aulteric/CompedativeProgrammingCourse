using System;
using System.Collections.Generic;
using System.Linq;

namespace BeautifulTriplets
{
    class Program
    {
        static int BeautifulTriplets(int d, int[] arr)
        {
            var count = 0;
            var set = new HashSet<int>(arr);

            foreach (var item in set)
                if (set.Contains(item + d) && set.Contains(item + 2 * d))
                    count++;

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
