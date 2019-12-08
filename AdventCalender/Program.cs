using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventCalender.DayProblems;
using AdventCalender.DayProblems.Day2;
using AdventCalender.DayProblems.Day5;

namespace AdventCalender {
    class Program {
        static void Main(string[] args) {
            string path1 = "InputFiles\\Day1Input.txt";
            string path2 = "InputFiles\\Day2Input.txt";
            string path2A = "InputFiles\\Day2InputA.txt";

            ConsoleIOSystem io = new ConsoleIOSystem();

            // Day 1
            Day1Problem1(path1, out var sumofDay1Problem1);
            io.WriteOutput(sumofDay1Problem1);

            Day1Problem2(path1, out var sumOfDay1Problem2);
            io.WriteOutput(sumOfDay1Problem2);

            // Day 2
            Day2Problem1(path2, out var answer);
            io.WriteOutput(answer);

            Day2Problem2(path2A, out var inputs);
            foreach (var input in inputs) {
                io.WriteOutput(input);
            }

            Console.ReadLine();
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
