using System;

namespace Divisors8
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == '0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.Write("1");
            if (counter > 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.Write("0");
                }
            }
        }
    }
}
