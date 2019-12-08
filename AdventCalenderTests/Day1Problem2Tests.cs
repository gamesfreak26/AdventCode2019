using System;
using AdventCalender.DayProblems;
using Xunit;

namespace AdventCalenderTests
{
    public class Day1Problem2Tests
    {
        [Fact]
        public void Fuel14()
        {
            Day1Problem2 day1Problem2 = new Day1Problem2();
            var sum = day1Problem2.SumNumber(14);
            Assert.Equal(2, sum);
        }

        [Fact]
        public void Fuel1969() {
            Day1Problem2 day1Problem2 = new Day1Problem2();
            var sum = day1Problem2.SumNumber(1969);
            Assert.Equal(966, sum);
        }

        [Fact]
        public void Fuel100756()
        {
            Day1Problem2 day1Problem2 = new Day1Problem2();
            var sum = day1Problem2.SumNumber(100756);
            Assert.Equal(50346, sum);
        }

        [Fact]
        public void FuelTest() {
            Day1Problem2 day1Problem2 = new Day1Problem2();
            string[] numberArray = new[] { "14", "1969", "100756" };
            var sum = day1Problem2.Sum(numberArray);
            Assert.Equal(51314, sum);
        }
    }
}