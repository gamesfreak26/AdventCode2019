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
            for (int num = 0; num < arrayOfInts.Length; num++)
            {
                switch (arrayOfInts[num])
                {
                    case 1:
                    {
                        var element1 = arrayOfInts[num + 1];
                        var element2 = arrayOfInts[num + 2];
                        var element = arrayOfInts[num + 3];
                        arrayOfInts[element] = arrayOfInts[element1] + arrayOfInts[element2];
                        num += 3;
                        break;
                    }
                    case 2:
                    {
                        var element1 = arrayOfInts[num + 1];
                        var element2 = arrayOfInts[num + 2];
                        var multiplicationElement = arrayOfInts[num + 3];
                        arrayOfInts[multiplicationElement] = arrayOfInts[element1] * arrayOfInts[element2];
                        num += 3;
                        break;
                    }

                    case 99:
                        return arrayOfInts;
                }
            }
            return arrayOfInts;
        }
    }
}
