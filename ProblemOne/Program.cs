using System;
using System.Collections.Generic;
using System.IO;

namespace ProblemOne {
    class Program {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Teej\source\repos\AdventCalender\ProblemOne\input.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            int num = 0;

            List<int> numList = new List<int>();

            var sum = Sum(lines);

            Console.WriteLine(sum);

        }

        private static int Sum(string[] lines)
        {
            int num;
            var sum = 0;
            foreach (var line in lines)
            {
                var lineTrim = line.Trim();
                if (int.TryParse(lineTrim, out num))
                {
                    if (num > 0)
                    {
                        num = ((int)Math.Floor((decimal)(num / 3))) - 2;
                        sum += num;
                    }
                    
                }
            }

            return sum;
        }
    }
}
