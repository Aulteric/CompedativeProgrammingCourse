using System;
using System.Linq;

namespace exam_prep
{
    class Program
    {
        public static void TrainTester()
        {
            string output = "";
            var trainsCount = int.Parse(Console.ReadLine());
            var arrayKeeper = new int[5, trainsCount];
            for (int i = 0; i < 5; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < trainsCount; j++)
                {
                arrayKeeper[i, j] = input[j];
                }

                output = TrainVerifier(input, trainsCount,output);
            }
                Console.WriteLine(output);
        }

        private static string TrainVerifier(int[] arrayKeeper, int trainsCount, string output)
        {
            bool tester = true;
            for (int i = 0; i < trainsCount - 2; i++)
            {
                if (Math.Abs(arrayKeeper[i] - arrayKeeper[i + 1]) >= 2
                    && Math.Abs(arrayKeeper[i + 1] - arrayKeeper[i + 2]) >= 2)
                {
                    tester = false;
                } else if (((arrayKeeper[i] < arrayKeeper[i + 1] && arrayKeeper[i] > arrayKeeper[i + 2]) 
                    || (arrayKeeper[i] > arrayKeeper[i + 1] && arrayKeeper[i] < arrayKeeper[i + 2])) && Math.Abs(arrayKeeper[i] - arrayKeeper[i + 2]) > 2)
                {
                    tester = false;
                }
            }
            if (tester)
            {
                return output + "1";
            }
            else
            {
                return output + "0";
            }
        }

        static void Main(string[] args)
        {
            TrainTester();
        }
    }
}
