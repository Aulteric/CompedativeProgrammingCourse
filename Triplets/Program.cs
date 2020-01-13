using System;
using System.Linq;

namespace Triplets
{
    class Program
    {
        static void Main(string[] args)
        {
            int scoreA = 0;
            int scoreB = 0;
            var Alice = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Bob = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int first = Alice[0] - Bob[0];
            int second = Alice[1] - Bob[1];
            int third = Alice[2] - Bob[2];

            if (first>0)
            {
                scoreA++;
            }
            else if (first < 0)
            {
               scoreB++;
            }
            if (second > 0)
            {
                scoreA++;
            }
            else if (second < 0)
            {
                scoreB++;
            }
            if (third > 0)
            {
                scoreA++;
            }
            else if (third < 0)
            {
                scoreB++;
            }


            Console.WriteLine($"{scoreA} {scoreB}");
        }
    }
}
