using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventCalender.DayProblems.Day5
{
    public class TestIOSystem : IOSystem
    {
        private Stack<int> _inputs;
        private List<int> Outputs { get; } = new List<int>();


        public TestIOSystem(int[] inputs) {
            _inputs = new Stack<int>(inputs.Reverse());
        }

        public int GetInput() {
            var input = _inputs.Pop();
            return input;
        }

        public void WriteOutput(int parameter) {
            Outputs.Add(parameter);
        }
    }
}
