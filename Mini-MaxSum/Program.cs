using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = InputIntLong();

            var minSum = GetMinSum(numbers);
            var maxSum = GetMaxSum(numbers);

            Console.WriteLine($"{minSum} {maxSum}");
        }

        static long GetMinSum(IEnumerable<long> numbers)
        {
            long result;

            if (numbers.All(x => x == numbers.First()))
            {
                result = numbers.First() * 4;
            }
            else
            {
                result = numbers.Where(x => x < numbers.Max()).Sum();
            }

            return result;
        }

        static long GetMaxSum(IEnumerable<long> numbers)
        {
            long result;

            if (numbers.All(x => x == numbers.First()))
            {
                result = numbers.First() * 4;
            }
            else
            {
                result = numbers.Where(x => x > numbers.Min()).Sum();
            }

            return result;
        }

        static List<long> InputIntLong()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt64(temp)).ToList();
    }
}
