using System;
using System.IO;
using System.Linq;

namespace SimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar) => ar.Sum();

        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar[0..len]);

            Console.WriteLine(result);
        }
    }
}
