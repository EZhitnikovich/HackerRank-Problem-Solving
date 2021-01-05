using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = InputIntList();
            Console.WriteLine(CountMax(number));
        }

        static int CountMax(IEnumerable<int> number)
            => number.Count(x=>x==number.Max());

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
