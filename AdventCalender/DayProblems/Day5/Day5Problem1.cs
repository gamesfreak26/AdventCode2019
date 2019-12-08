using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems.Day5
{
    public class Day5Problem1 : IOSystem
    {
        ConsoleIOSystem consoleIOSystem = new ConsoleIOSystem();

        public int[] Something(int[] arrayOfInts) {
            for (int num = 0; num < arrayOfInts.Length; num++) {
                switch (arrayOfInts[num]) {
                    case 1: {
                        var element1 = arrayOfInts[num + 1];
                        var element2 = arrayOfInts[num + 2];
                        var element = arrayOfInts[num + 3];
                        arrayOfInts[element] = arrayOfInts[element1] + arrayOfInts[element2];
                        num += 3;
                        break;
                    }
                    case 2: {
                        var element1 = arrayOfInts[num + 1];
                        var element2 = arrayOfInts[num + 2];
                        var multiplicationElement = arrayOfInts[num + 3];
                        arrayOfInts[multiplicationElement] = arrayOfInts[element1] * arrayOfInts[element2];
                        num += 3;
                        break;
                    }
                    case 3: {
                        var userInput = GetInput();
                        var element1 = arrayOfInts[num + 1];
                        arrayOfInts[element1] = userInput;
                        break;
                    }
                    case 4: {
                        var element1 = arrayOfInts[num + 1];
                        WriteOutput(arrayOfInts[element1]);
                        break;
                    }
                    case 99:
                        return arrayOfInts;
                }
            }
            return arrayOfInts;
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
