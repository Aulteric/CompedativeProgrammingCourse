using System;

namespace Non_increasing_sequences
{
    class Program
    {
        static void SequenceGenerator(int input, int[] arr,
                         int sum, int index)
        {

            if (sum == input)
            {
                for (int i = 0; i < index; i++)
                {
                    Console.Write(arr[i] + " ");
                }

                Console.WriteLine();
                return;
            }

            int num = 1;
 
            while (num <= input - sum &&
                                 (index == 0 ||
                         num <= arr[index - 1]))
            {
                arr[index] = num;

                SequenceGenerator(input, arr, sum + num,
                                         index + 1);

                num++;
            }
        }
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            SequenceGenerator(input, array, 0, 0);
        }
    }
}
