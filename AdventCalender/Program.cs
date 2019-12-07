using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventCalender.DayProblems;
using AdventCalender.DayProblems.Day2;

namespace AdventCalender {
    class Program {
        static void Main(string[] args) {
            string path1 = "InputFiles\\Day1Input.txt";
            string path2 = "InputFiles\\Day2Input.txt";
            string path2A = "InputFiles\\Day2InputA.txt";

            #region Day1Problem1 Region
                Day1Problem1 day1Problem1 = new Day1Problem1();

                string[] lines = day1Problem1.ReadLines(path1);

                var sumofDay1Problem1 = day1Problem1.Sum(lines);
            #endregion ^ Day1Problem1

            #region Day1Problem2 Region
                Day1Problem2 day1Problem2 = new Day1Problem2();
                var sumOfDay1Problem2 = day1Problem2.Sum(lines);  // Is Wrong

                var sumOfBothProblems = sumOfDay1Problem2;
            #endregion ^ Day1Problem2

            #region Day2Problem1 Region

                Day2Problem1 day2Problem1 = new Day2Problem1();

                var linesForDay2 = File.ReadAllText(path2);
                var splitLines = linesForDay2.Split(",");

                var intArray = splitLines.Select(x => int.Parse(x)).ToArray();

                int[] something = day2Problem1.Something(intArray);
                #endregion ^ Day2Problem1 Region

            #region Day2Problem2 Region

                Day2Problem2 day2Problem2 = new Day2Problem2();
                var day2Pt2Lines = day2Problem2.ReadLine(path2A);

                var splitLinesPt2 = day2Pt2Lines.Split(",");
                var intArrayPt2 = splitLinesPt2.Select(x => int.Parse(x)).ToArray();
                var inputs = day2Problem2.FindInputs(intArrayPt2);
                #endregion ^ Day2Problem2 Region

            Console.ReadLine();
        }
    }
}
