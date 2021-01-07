using System;
using System.Collections.Generic;
using System.Linq;

namespace BetweenTwoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = InputIntList();

            List<int> brr = InputIntList();
            int total = GetTotalX(arr, brr);

            Console.WriteLine(total);
        }

        static int GetTotalX(IEnumerable<int> arr, IEnumerable<int> brr)
        {
            int result = 0;

            for(int i = arr.ElementAt(arr.Count()-1); i <= brr.First(); i++)
            {
                if (arr.All(x => i % x == 0) && brr.All(x=>x%i==0))
                {
                    result++;
                }
            }

            return result;
        }

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
