using System;
using System.Collections.Generic;
using System.Text;
using AdventCalender.DayProblems;
using Xunit;

namespace AdventCalenderTests
{
    public class Day2Problem1Tests
    {
        [Fact]
        public void TestThatArrayIsCorrectlyInitialised()
        {
            int[] numberArray = new[] {1, 0, 0, 0, 99};
            Assert.Equal(1, numberArray[0]);
        }

        [Fact]
        public void Test1() {
            int[] numberArray = new[] { 1, 0, 0, 0, 99 };
            int[] answerArray = new[] {2, 0, 0, 0, 99};

            Day2Problem1 day2Problem1 = new Day2Problem1();
            var arrays =  day2Problem1.Something(numberArray);
            Assert.Equal(answerArray, arrays);
        }
    }
}
