using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var score = new List<int>();
        score.Add(0);
        score.Add(0);

        int first = a[0] - b[0];
        int second = a[1] - b[1];
        int third = a[2] - b[2];

        if (first > 0)
        {
            score[0]++;
        }
        else if (first < 0)
        {
            score[1]++;
        }
        if (second > 0)
        {
            score[0]++;
        }
        else if (second < 0)
        {
            score[1]++;
        }
        if (third > 0)
        {
            score[0]++;
        }
        else if (third < 0)
        {
            score[1]++;
        }
        return score;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
