using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTheTriplets
{
    class Program
    {
        static List<int> CompareTriplets(List<int> first, List<int> second)
        {
            if (first.Count != second.Count)
                throw new Exception("Different length");

            List<int> result = new List<int>() { 0, 0 };

            for(int i = 0; i < second.Count; i++)
            {
                if(first[i] > second[i])
                {
                    result[0]++;
                }
                else if(first[i] < second[i])
                {
                    result[1]++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            List<int> a = InputIntList();
            List<int> b = InputIntList();

            Console.WriteLine(String.Join(" ", CompareTriplets(a,b)));
        }

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
