using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = int.Parse(Console.ReadLine());
            var number = InputIntList();
            Console.WriteLine(CountMax(number.GetRange(0, len)));
        }

        static long CountMax(IEnumerable<int> number)
        {
            int maxValue = number.First();
            int count = 0;
            foreach (int item in number)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                    count = 1;
                }
                else if(item == maxValue)
                {
                    count++;
                }
            }
            return count;
        } 

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
