using System;
using System.Collections.Generic;
using AdventCalender.DayProblems;

namespace AdventCalender {
    class Program {
        static void Main(string[] args) {
            string path1 = "InputFiles\\Day1Input.txt";
            string path2 = "InputFiles\\Day2Input.txt";

            #region Day1Problem1 Region
            Day1Problem1 day1Problem1 = new Day1Problem1();
            string[] lines = day1Problem1.ReadLines(path1);
            var sumofDay1Problem1 = day1Problem1.Sum(lines);
            #endregion ^ Day1Problem1

            #region Day1Problem2 Region
            Day1Problem2 day1Problem2 = new Day1Problem2();
            var sumOfDay1Problem2 = day1Problem2.Sum(lines);  // Is Wrong

            var sumOfBothProblems = sumofDay1Problem1 + sumOfDay1Problem2;
            #endregion ^ Day1Problem2

            #region Day2Problem1 Region

            Day2Problem1 day2Problem1 = new Day2Problem1();

            string[] linesForDay2 = day2Problem1.ReadLines(path2);
            var splitLines = linesForDay2[0].Split(",");

            int num = 0;

            List<int> numList = new List<int>();
            foreach (var line in splitLines) {
                var lineTrim = line.Trim();
                if (int.TryParse(lineTrim, out num)) {
                    numList.Add(num);
                }
            }
            day2Problem1.Something(numList);
            #endregion ^ Day2Problem1 Region

            Console.ReadLine();
        }
    }
}
