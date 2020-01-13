using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var bills = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(x => x).ToArray();
            var payedBills = Console.ReadLine().Split(' ').Select(double.Parse).OrderByDescending(x => x).ToArray();
            var nonPayedList = new List<double>();
            int savedCounterNonPayed = 0;
            int savedCounterPayed = 0;
            bool tester = true;
            for (int i = savedCounterNonPayed; i < bills.Length; i++)
            {
                for (int j = savedCounterPayed; j < payedBills.Length; j++)
                {
                    tester = true;

                    if (bills[i] == payedBills[j])
                    {
                        savedCounterNonPayed = i;
                        savedCounterPayed = j + 1;
                        tester = false;
                        break;
                    }
                }

                if (tester)
                {
                    nonPayedList.Add(bills[i]);
                }
            }

            foreach (var bill in nonPayedList)
            {
                Console.Write($"{bill:F2} ");
            }
        }
    }
}
