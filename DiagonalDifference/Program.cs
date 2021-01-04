using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            List<List<int>> arr = new List<List<int>>();

            for(int i = 0; i < len; i++)
            {
                arr.Add(InputIntList());
            }

            int result = DiagonalCalculator.GetDiagonalDifference(arr);

            Console.WriteLine(Math.Abs(result));
        }

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }

    class DiagonalCalculator
    {
        public static int GetDiagonalDifference(List<List<int>> arr)
        {
            return GetMainDiagonalSum(arr) - GetSecondaryDiagonalSum(arr);
        }

        public static int GetMainDiagonalSum(List<List<int>> arr)
        {
            int sum = 0;

            for(int i = 0; i < arr.Count; i++)
            {
                sum += arr[i][i];
            }

            return sum;
        }

        public static int GetSecondaryDiagonalSum(List<List<int>> arr)
        {
            int sum = 0;

            for(int i = arr.Count -1; i>=0; i--)
            {
                sum += arr[arr.Count - 1 - i][i];
            }

            return sum;
        }
    }
}
