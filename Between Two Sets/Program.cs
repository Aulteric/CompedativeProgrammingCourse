using System;
using System.Linq;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //No need to capture number of elments in set A and B as I use foreach loop to iterate them.
            Console.ReadLine();
            var a_temp = Console.ReadLine().Split(' ');
            var setA = Array.ConvertAll(a_temp, Int32.Parse);
            var b_temp = Console.ReadLine().Split(' ');
            var setB = Array.ConvertAll(b_temp, Int32.Parse);
            int total = getTotalX(setA, setB);
            Console.WriteLine(total);
        }

        static int getTotalX(int[] a, int[] b)
        {
            var totalX = 0;
            var maxA = a.Max();
            var minB = b.Min();
            var counter = 1;
            var multipleOfMaxA = maxA;

            while (multipleOfMaxA <= minB)
            {
                var validNum = true;

                for (int i = 0; i < a.Length; i++)
                {
                    if (multipleOfMaxA % a[i] != 0)
                    {
                        validNum = false;
                        break;
                    }
                }

                if (validNum)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] % multipleOfMaxA != 0)
                        {
                            validNum = false;
                            break;
                        }
                    }
                }

                if (validNum)
                {
                    totalX++;
                }

                counter++;
                multipleOfMaxA = maxA * counter;
            }
            return totalX;
        }
    }
}
