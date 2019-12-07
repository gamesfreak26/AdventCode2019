using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems
{
    public class Day2Problem1
    {
        public string[] ReadLines(string path) {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }

        public void Something(List<int> arrayOfInts)
        {
            for (int num = 0; num < arrayOfInts.Count; num++)
            {
                switch (arrayOfInts[num])
                {
                    case 1:
                        Console.WriteLine("Opcode 1");
                        var num1 = arrayOfInts[num + 1];
                        var num2 = arrayOfInts[num + 2];
                        var sum = num1 + num2;
                        var element = arrayOfInts[num + 3];
                        arrayOfInts[element] = sum;
                        break;
                    case 2:
                        Console.WriteLine("Opcode 2");
                        break;
                    case 99:
                        Console.WriteLine("Opcode 99");
                        return;
                    default:
                        Console.WriteLine($"No Opcode: {arrayOfInts[num]}");
                        break;
                }
            }
        }
    }
}
