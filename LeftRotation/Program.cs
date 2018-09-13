using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, string b)
    {
        int d = Convert.ToInt32(b);

        int[] aux = new int[a.Length];

        for (int j = 1; j <= d; j++)
        {
            aux = a.Skip(1).Concat(a.Take(1)).ToArray();
            a = aux;
        }

        return aux;

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //string[] nd = Console.ReadLine().Split(' ');

        int[] a = {1,2,3,4,5 };

        //int n = Convert.ToInt32(nd[0]);

        //int d = Convert.ToInt32(nd[1]);

        //int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        string d = Console.ReadLine();

        int[] result = rotLeft(a, d);

        //textWriter.WriteLine(string.Join(" ", result));

        //textWriter.Flush();
        //textWriter.Close();
    }
}
