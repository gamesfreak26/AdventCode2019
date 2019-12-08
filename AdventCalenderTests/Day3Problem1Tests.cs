﻿using System;
using System.Collections.Generic;
using System.Text;
using AdventCalender.DayProblems.Day3;
using Xunit;

namespace AdventCalenderTests
{
    public class Day3Problem1Tests
    {
        [Theory]
        [InlineData("R8,U5,L5,D3", "U7,R6,D4,L4")]
        [InlineData("R75,D30,R83,U83,L12,D49,R71,U7,L72", "U62, R66, U55, R34, D71, R55, D58, R83")]
        [InlineData("R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51", "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7")]
        public void Test(string input1, string input2) {
            Day3Problem1 day3Problem1 = new Day3Problem1();
            var test = day3Problem1.Something(input1, input2);
        }
    }
}
