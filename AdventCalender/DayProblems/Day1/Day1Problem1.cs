using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender
{
    public class Day1Problem1
    {
        public string[] ReadLines(string path) {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }

        public  int Sum(string[] lines) {
            int num;
            var sum = 0;
            foreach (var line in lines) {
                var lineTrim = line.Trim();
                if (int.TryParse(lineTrim, out num)) {
                    num = (num / 3) - 2;  // Floors automatically
                    sum += num;
                }
            }
            return sum;
        }

        public int SumNumber(int num) {
            num = (num / 3) - 2;  // Floors automatically
            var sum = 0;
            sum += num;
            return sum;
        }
    }
}
