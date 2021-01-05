using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            char rungSymbol = '#';
            char surroundingSymbol = ' ';
            Console.WriteLine(MakeStaircase(len, rungSymbol, surroundingSymbol));
        }

        static string MakeStaircase(int len, char rungSymbol, char surroundingSymbol)
        {
            string staircase = string.Empty;
            for (int i = 1; i <= len; i++)
            {
                staircase += "\n".PadLeft(i + 1, rungSymbol).PadLeft(len + 1, surroundingSymbol);
            }

            return staircase;
        }
    }
}
