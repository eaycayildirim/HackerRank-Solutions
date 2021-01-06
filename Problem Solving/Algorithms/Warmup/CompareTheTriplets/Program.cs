﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int[] array = new int[2];
        List<int> points = new List<int>(array);

        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
                points[0]++;

            else if (b[i] > a[i])
                points[1]++;
        }
        return points;
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
