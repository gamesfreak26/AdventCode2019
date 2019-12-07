using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCalender.DayProblems.Day2
{
    public class Day2Problem2
    {

        public string ReadLine(string path) {
            var lines = System.IO.File.ReadAllText(path);
            return lines;
        }

        public int[] FindInputs(int[] arrayInts)
        {
            int[] inputs;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var temp = new int[arrayInts.Length];
                    arrayInts.CopyTo(temp,0);

                    temp[1] = i;
                    temp[2] = j;
                    
                    var answer = Something(temp);
                    if (answer[0] == 19690720)
                    {
                        inputs = new[] {i, j};
                        return inputs;
                    }
                }
            }

            inputs = new[] {0, 0};
            return inputs;
        }

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

                    case 99:
                        return arrayOfInts;
                }
            }
            return arrayOfInts;
        }

    }
}
