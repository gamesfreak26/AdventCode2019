using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems.Day5
{
    public class ConsoleIOSystem : IOSystem
    {
        public int GetInput() {
            var num = Console.ReadLine();
            return int.Parse(num);
        }

        public void WriteOutput(int parameter) {
            Console.WriteLine(parameter);
        }
    }
}
