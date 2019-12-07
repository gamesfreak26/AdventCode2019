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

        public int[] Something(int[] arrayOfInts)
        {
            for (int num = 0; num < arrayOfInts.Length; ++num)
            {
                if (num % 3 == 0)
                {
                    switch (arrayOfInts[num]) {
                        case 1:
                            Console.WriteLine("Opcode 1");

                            var element1 = arrayOfInts[num + 1];
                            var element2 = arrayOfInts[num + 2];
                            var sum = arrayOfInts[element1] + arrayOfInts[element2];
                            var element = arrayOfInts[num + 3];
                            arrayOfInts[element] = sum;
                            break;
                        case 2:
                            Console.WriteLine("Opcode 2");

                            var num3 = arrayOfInts[num + 1];
                            var num4 = arrayOfInts[num + 2];
                            var sum1 = num3 * num4;
                            element1 = arrayOfInts[num + 3];
                            arrayOfInts[element1] = sum1;
                            break;
                        case 99:
                            Console.WriteLine("Opcode 99");
                            return arrayOfInts;
                        default:
                            Console.WriteLine($"No Opcode: {arrayOfInts[num]}");
                            break;
                    }
                }
            }

            return arrayOfInts;
        }
    }
}
