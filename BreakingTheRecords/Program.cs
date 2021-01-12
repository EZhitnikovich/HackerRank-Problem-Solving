using System;
using System.Collections.Generic;
using System.Linq;

namespace BreakingTheRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            var scores = InputIntList();

            Console.WriteLine($"{GetBestScoreCount(scores)} {GetWorstRecordCount(scores)}");
        }

        static int GetBestScoreCount(IEnumerable<int> scores)
        {
            int result = 0;
            int tempMax = scores.First();
            foreach(var el in scores)
            {
                if(el > tempMax)
                {
                    tempMax = el;
                    result++;
                }
            }

            return result;
        }

        static int GetWorstRecordCount(IEnumerable<int> scores)
        {
            int result = 0;
            int tempMin = scores.First();
            foreach(var el in scores)
            {
                if (el < tempMin)
                {
                    tempMin = el;
                    result++;
                }
            }

            return result;
        }

        static List<int> InputIntList()
            => Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
    }
}
