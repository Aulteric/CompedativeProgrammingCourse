using System;
using System.Linq;

namespace Mini_MaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            var Max = arr.Max();
            var Min = arr.Min();
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"{sum - Max} {sum - Min}");
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            miniMaxSum(arr);
        }
    }
}
