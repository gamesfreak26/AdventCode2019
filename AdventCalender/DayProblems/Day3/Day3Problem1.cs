using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using AdventCalender.DayProblems.Day5;

namespace AdventCalender.DayProblems.Day3 {
    public class Day3Problem1 {
        //"R8,U5,L5,D3", "U7,R6,D4,L4"
        ConsoleIOSystem io = new ConsoleIOSystem();

        public string ReadLine(string path) {
            var lines = File.ReadAllText(path);
            return lines;
        }

        public string Something(string input1, string input2) {
            var seperatedInput1 = input1.Split(",");
            var seperatedInput2 = input2.Split(",");

            var seperatedInput1Length = seperatedInput1.Length;
            var seperatedInput2Length = seperatedInput2.Length;

            ValueTuple<char, string> direction;
            //List<ValueTuple<char,string>> inputDirections1 = new List<ValueTuple<char, string>>();
            //List<ValueTuple<char, string>> inputDirections2 = new List<ValueTuple<char, string>>();

            var inputDirections1 = seperatedInput1.Select(s => (s[0], s.Substring(1))).ToList();
            var inputDirections2 = seperatedInput2.Select(s => (s[0], s.Substring(1))).ToList();

            (int, int) WireDirection = (0, 0);


            //foreach (var s in seperatedInput1) {
            //    direction.Item1 = s[0];
            //    direction.Item2 = s.Substring(1);
            //    //directions.Add(direction);
            //}

            return "Hello";
        }

        public class Direction {

            private Dictionary<string, (int, int)> _directions = new Dictionary<string, (int, int)>();

            public Dictionary<string, (int, int)> Directions => _directions;

            public Direction() {
                _directions.Add("Up", (0,1));
                _directions.Add("Down", (0, -1));
                _directions.Add("Left", (-1, 0));
                _directions.Add("Left", (1, 0));
            }

            public (int, int) AddDirection(string direction, int adder, (int, int) tuple) {

                switch (direction) {
                    case "Up": {
                        var newNumber = adder + tuple.Item2;
                        var answer = (tuple.Item1, newNumber);
                        return answer;
                    }


                    case "Down": {
                        var newNumber = adder + tuple.Item2;
                        var answer = (tuple.Item1, newNumber);
                        return answer;
                    }
                        
                }
                return (0, 0);
            }

        }
    }

    
}
