using System;
using System.Collections.Generic;
using System.Linq;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            List<int> numbers = InputIntList().GetRange(0, len);

            var pZero = GetPercentOfZero(numbers);
            var pPositive = GetPercentOfPositive(numbers);
            var pNegative = GetPercentOfNegative(numbers);

            Console.WriteLine(string.Format("{0:f6}\n" +
                                            "{1:f6}\n" +
                                            "{2:f6}",
                                            pPositive,
                                            pNegative,
                                            pZero));
        }

        static double GetPercentOfZero(List<int> numbers)
            => numbers.Where(x => x == 0).Count() / (double)numbers.Count;

        static double GetPercentOfPositive(List<int> numbers)
            => numbers.Where(x => x > 0).Count() / (double)numbers.Count;

        static double GetPercentOfNegative(List<int> numbers)
            => numbers.Where(x => x < 0).Count() / (double)numbers.Count;

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
