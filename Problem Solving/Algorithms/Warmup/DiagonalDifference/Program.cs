﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int principalDiagonal = 0;
        int reverseDiagonal = 0;
        for (int i = 0; i < arr.Count; i++)
            principalDiagonal += arr[i][i];

        for (int i = 0; i < arr.Count; i++)
            reverseDiagonal += arr[i][arr.Count - 1 - i];

        return Math.Abs(principalDiagonal - reverseDiagonal);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}