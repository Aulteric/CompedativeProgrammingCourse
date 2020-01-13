using System;
using System.Linq;

namespace Fences
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeCount = int.Parse(Console.ReadLine());
            int biggestX = int.MinValue;
            int smallestX = int.MaxValue;
            int biggestY = int.MinValue;
            int smallestY = int.MaxValue;
            for (int i = 0; i < treeCount; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (input[0] > biggestX)
                {
                    biggestX = input[0];
                }
                if (input[0] < smallestX)
                {
                    smallestX = input[0];
                }
                if (input[1] > biggestY)
                {
                    biggestY = input[1];
                }
                if (input[1] < smallestY)
                {
                    smallestY = input[1];
                }
            }
            var BiggestDifference = Math.Max(Math.Abs(biggestX - smallestX), Math.Abs(biggestY - smallestY));
           // if(BiggestDifference == 0)
           // {
           //     BiggestDifference = 1;
           // }
            Console.WriteLine((BiggestDifference + 2)*4);
        }
    }
}
