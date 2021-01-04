using System;
using System.Linq;

namespace AVeryBigSum
{
    class Program
    {
        static long AVeryBigSum(long[] ar)
            => ar.Sum();

        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), temp => long.Parse(temp));

            long result = AVeryBigSum(ar[0..len]);

            Console.WriteLine(result);
        }
    }
}
