using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems.Day5
{
    public class Day5Problem1 : IOSystem
    {
        ConsoleIOSystem consoleIOSystem = new ConsoleIOSystem();

        public string ReadLines(string path) {
            var lines = System.IO.File.ReadAllText(path);
            return lines;
        }

        

        public int GetInput() {
            var input = consoleIOSystem.GetInput();
            return input;
        }

        public void WriteOutput(int parameter) {
            consoleIOSystem.WriteOutput(parameter);
        }
    }
}
