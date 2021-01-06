using System;
using System.Collections.Generic;
using System.Linq;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());
            var marks = InputIntList(len);

            Console.WriteLine(string.Join("\n",ConvertMarks(marks).ToList()));
        }

        static List<int> ConvertMarks(List<int> marks)
        {
            for(int i = 0; i < marks.Count(); i++)
            {
                marks[i] = ConvertMark(marks[i]);
            }

            return marks;
        }

        static int ConvertMark(int mark)
        {
            if (!(mark < 38))
            {
                if (mark%5>=3 && mark%5!=0)
                {
                    mark = mark - mark % 5 + 5; 
                }
            }

            return mark;
        }

        static List<int> InputIntList(int len)
        {
            var lst = new List<int>();

            for(int i = 0; i < len; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }

            return lst;
        }
    }
}
