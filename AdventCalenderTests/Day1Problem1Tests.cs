using System;
using AdventCalender;
using Xunit;


namespace AdventCalenderTests
{
    public class Day1Problem1Tests
    {
        
        [Fact]
        public void Test1() {
            Day1Problem1 day1Problem1 = new Day1Problem1();
            var sum = day1Problem1.SumNumber(14);
            Assert.Equal(2, sum);
        }
    }
}
