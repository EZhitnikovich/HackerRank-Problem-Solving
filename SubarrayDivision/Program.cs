using System;
using System.Collections.Generic;
using System.Linq;

namespace SubarrayDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            var chocolate = InputIntList();
            var temp = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);

            int result = Birtday(chocolate, d, m);

            Console.WriteLine(result);
        }

        static int Birtday(List<int> chocolate, int day, int month)
        {
            int result = 0;
            for(int i = 0; i <= chocolate.Count() - month; i++)
            {
                int temp = 0;

                for(int j = i; j < i + month; j++)
                {
                    temp += chocolate[j];
                }

                if(temp == day)
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
