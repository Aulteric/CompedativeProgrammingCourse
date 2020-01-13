using System;
using System.Linq;

namespace CountingOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaxDistance = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int operations = 0;

            for (int i = 0; i < arr.Length - 1;  i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) > MaxDistance)
                {
                    operations += Math.Abs(MaxDistance - Math.Abs(arr[i] - arr[i + 1]));

                    if (arr[i] > arr[i+1])
                    {
                        arr[i + 1] -= MaxDistance - Math.Abs(arr[i] - arr[i + 1]);
                    }
                    else
                    {
                        arr[i + 1] += MaxDistance - Math.Abs(arr[i] - arr[i + 1]);
                    }
                }
            }
            Console.WriteLine(operations);
        }
    }
}
