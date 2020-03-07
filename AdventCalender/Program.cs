using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventCalender.DayProblems;
using AdventCalender.DayProblems.Day2;
using AdventCalender.DayProblems.Day3;
using AdventCalender.DayProblems.Day5;

namespace AdventCalender {
    class Program {
        static void Main(string[] args) {
            string path1 = "InputFiles\\Day1Input.txt";
            string path2 = "InputFiles\\Day2Input.txt";
            string path2A = "InputFiles\\Day2InputA.txt";
            string path5A = "InputFiles\\Day5Problem1.txt";

            ConsoleIOSystem io = new ConsoleIOSystem();

            // Day 1
            #region Day Code
            //Day1Problem1(path1, out var sumofDay1Problem1);

            //Day1Problem2(path1, out var sumOfDay1Problem2);

            //// Day 2
            //Day2Problem1(path2, out var answer);

            //Day2Problem2(path2A, out var inputs);

            //// Day 3
            //Day3Problem1();

            #endregion ^ Day Code

            // Day 5
            Day5Problem1(path5A);

            Console.ReadLine();
        }

        private static void Day5Problem1(string path) {
            Day5Problem1 day5Problem1 = new Day5Problem1();
            var lines = day5Problem1.ReadLines(path);
        }

        private static void Day3Problem1()
        {
            Day3Problem1 day3Problem1 = new Day3Problem1();
            var tuples = day3Problem1.PopulateTuples();
            Direction direction = new Direction();


            var num = 0;
            var wire1 = tuples[0]; // eg. (R, 5)
            var wire2 = tuples[1];

            var pointsOfWire1 = direction.FindPoints(wire1).ToArray();
            var pointsOfWire2 = direction.FindPoints(wire2).ToArray();

            var intersections = pointsOfWire1.Intersect(pointsOfWire2).ToArray();
        }

        private static void Day2Problem2(string path2A, out int[] inputs) {
            Day2Problem2 day2Problem2 = new Day2Problem2();
            var day2Pt2Lines = day2Problem2.ReadLine(path2A);

            var splitLinesPt2 = day2Pt2Lines.Split(",");
            var intArrayPt2 = splitLinesPt2.Select(x => int.Parse(x)).ToArray();
            inputs = day2Problem2.FindInputs(intArrayPt2);
        }

        private static void Day2Problem1(string path2, out int answer) {
            Day2Problem1 day2Problem1 = new Day2Problem1();

            var linesForDay2 = File.ReadAllText(path2);
            var splitLines = linesForDay2.Split(",");

            var intArray = splitLines.Select(x => int.Parse(x)).ToArray();

            int[] something = day2Problem1.Something(intArray);
            answer = something[0];
        }

        private static void Day1Problem2(string path1, out int sumOfDay1Problem2) {
            Day1Problem2 day1Problem2 = new Day1Problem2();
            string[] lines = day1Problem2.ReadLines(path1);
            sumOfDay1Problem2 = day1Problem2.Sum(lines);

            var answer = sumOfDay1Problem2;
        }

        private static void Day1Problem1(string path1, out int sumofDay1Problem1) {
            Day1Problem1 day1Problem1 = new Day1Problem1();

            string[] lines = day1Problem1.ReadLines(path1);

            sumofDay1Problem1 = day1Problem1.Sum(lines);
        }
    }
}
