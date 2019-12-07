using System;
using AdventCalender.DayProblems;

namespace AdventCalender {
    class Program {
        static void Main(string[] args) {
            string path = "InputFiles\\Day1Input.txt";

            Day1Problem1 day1Problem1 = new Day1Problem1();
            string[] lines = day1Problem1.ReadLines(path);
            var sumofDay1Problem1 = day1Problem1.Sum(lines);
            
            Day1Problem2 day1Problem2 = new Day1Problem2();
            var sumOfDay1Problem2 = day1Problem2.Sum(lines);

            var sumOfBothProblems = sumofDay1Problem1 + sumOfDay1Problem2;

        }
    }
}
