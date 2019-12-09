using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using AdventCalender.DayProblems.Day5;

namespace AdventCalender.DayProblems.Day3 {
    public class Day3Problem1 {
        //"R8,U5,L5,D3", "U7,R6,D4,L4"
        string path3 = "InputFiles\\Day3Input.txt";
        ConsoleIOSystem io = new ConsoleIOSystem();
        List<List<(char, string)>> _tuples = new List<List<(char, string)>>();

        public List<List<(char, string)>> Tuples { get; private set; }

        public string[] ReadLine(string path) {
            var lines = File.ReadAllLines(path);
            return lines;
        }

        public List<(char, string)> SeperateInput(string input) {

            var separatedInput = input.Split(",");
            var inputDirections = separatedInput.Select(s => (s[0], s.Substring(1))).ToList();
            return inputDirections;
        }

        public List<List<(char,string)>> PopulateTuples()
        {
            var day3Problem1Input = ReadLine(path3);
            foreach (var day3Input in day3Problem1Input) {
                var output = SeperateInput(day3Input);
                _tuples.Add(output);
            }
            return _tuples;
        }
    }
}
