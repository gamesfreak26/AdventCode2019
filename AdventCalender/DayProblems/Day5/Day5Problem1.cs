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

        public int[] OpCodes(int[] arrayOfInts) {
            for (int num = 0; num < arrayOfInts.Length; num++) {

                var opCode = arrayOfInts[num] % 100;

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
                        /* Opcode 3 takes a single integer as input and saves it to the position given by its only parameter. For example, the instruction 3,50 would take an input value and store it at address 50. */
                        num += 1;
                        break;
                    }

                    case 4: {
                        /* Opcode 4 outputs the value of its only parameter. For example, the instruction [4,50] would output the value at address 50. */
                        var parameter = arrayOfInts[num + 1];
                        WriteOutput(parameter);
                        num += 2;
                        break;
                    }

                    case 99:
                        return arrayOfInts;
                }
            }
            return arrayOfInts;
        }

        private void ReadInput()
        {

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
