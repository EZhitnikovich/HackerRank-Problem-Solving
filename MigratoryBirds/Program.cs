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

    static int MigratoryBirds(List<int> arr)
    {
        int[] birds = new int[6];

        foreach(var el in arr)
        {
            birds[el]++;
        }

        return birds.ToList().IndexOf(birds.Max());
    }

    static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = MigratoryBirds(arr);

        Console.WriteLine(result);
    }
}
