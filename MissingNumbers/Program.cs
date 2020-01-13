using System;
using System.Collections.Generic;

namespace MissingNumbers
{
    class Program
    {
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            var frequency = new int[201];
            frequency[100] = 1;

            var pivot = brr[0];
            var list = new List<int>();
            for (var i = 1; i < brr.Length; i++)
            {
                var diff = brr[i] - pivot;
                frequency[100 + diff]++;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                var diff = arr[i] - pivot;
                frequency[100 + diff]--;
            }

            for (var i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                    list.Add(pivot + (i - 100));
            }

            return list.ToArray();

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int m = Convert.ToInt32(Console.ReadLine());

            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
            ;
            int[] result = missingNumbers(arr, brr);

            textWriter.WriteLine(string.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
