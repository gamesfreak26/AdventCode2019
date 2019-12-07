using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems
{
    public class Day1Problem2
    {
        public string[] ReadLines(string path) {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }

        public int Sum(string[] lines) {
            int num;
            var sum = 0;
            foreach (var line in lines) {
                var lineTrim = line.Trim();
                    if (int.TryParse(lineTrim, out num))
                    {
                        sum = SumNumber(num);
                    }
            }
            return sum;
        }

        public int SumNumber(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                num = (num / 3) - 2;  // Floors automatically
                if (num < 0) { num = 0;}
                sum += num;
            }
            return sum;
        }
    }
}
