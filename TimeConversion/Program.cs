using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time12 = Console.ReadLine();
            Console.WriteLine(ConvertTo24Format(time12));
        }

        static string ConvertTo24Format(string time12)
        {
            string time24 = string.Empty;
            if (time12.Contains("AM"))
            {
                var timeElements = time12.Replace("AM", "").Split(':');
                if (timeElements[0].Equals("12"))
                {
                    timeElements[0] = "00";
                }
                time24 = $"{timeElements[0]}:{timeElements[1]}:{timeElements[2]}";
            }
            else if (time12.Contains("PM"))
            {
                var timeElements = time12.Replace("PM", "").Split(':');
                if (!timeElements[0].Equals("12"))
                {
                    timeElements[0] = Convert.ToString(int.Parse(timeElements[0]) + 12);
                }
                time24 = $"{timeElements[0]}:{timeElements[1]}:{timeElements[2]}";
            }

            return time24;
        }
    }
}
