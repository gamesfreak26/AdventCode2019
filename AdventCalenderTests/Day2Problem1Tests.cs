using System;
using System.Collections.Generic;
using System.Text;
using AdventCalender.DayProblems;
using Xunit;

namespace AdventCalenderTests
{
    public class Day2Problem1Tests
    {
        //[Theory] 
        //[InlineData(1, 0, 0, 0, 99)]


        //[Fact]
        //public void TestTest(string input, string output)
        //{

        //}

        [Fact]
        public void TestThatArrayIsCorrectlyInitialised()
        {
            int[] numberArray = new[] {1, 0, 0, 0, 99};
            Assert.Equal(1, numberArray[0]);
        }

        [Fact]
        public void Test1Addition() {
            int[] numberArray = new[] { 1, 0, 0, 0, 99 };
            int[] answerArray = new[] {2, 0, 0, 0, 99};

            Day2Problem1 day2Problem1 = new Day2Problem1();
            var testArray =  day2Problem1.Something(numberArray);
            Assert.Equal(answerArray, testArray);
        }

        [Fact]
        public void Test2Multiplication()
        {
            Day2Problem1 day2Problem1 = new Day2Problem1();
            int[] numberArray = new[] {2, 3, 0, 3, 99};
            int[] answerArray = new[] {2, 3, 0, 6, 99};
            var testArray = day2Problem1.Something(numberArray);
            Assert.Equal(answerArray, testArray);
        }

        [Fact]
        public void Test3Multiplication()
        {
            Day2Problem1 day2Problem1 = new Day2Problem1();
            int[] numberArray = new[] {2, 4, 4, 5, 99, 0};
            int[] answerArray = new[] {2, 4, 4, 5, 99, 9801};
            var testArray = day2Problem1.Something(numberArray);
            Assert.Equal(answerArray, testArray);
        }

        [Fact]
        public void Test4()
        {
            Day2Problem1 day2Problem1 = new Day2Problem1();
            
            int[] numberArray = new[] {1, 1, 1, 4, 99, 5, 6, 0, 99};
            int[] answerArray = new[] {30, 1, 1, 4, 2, 5, 6, 0, 99};
            //1,1,1,4,99,5,6,0,99

            var answer = String.Join(",", answerArray);

            var testArray = day2Problem1.Something(numberArray);

            var test = String.Join(",", numberArray);

            Assert.Equal(answer, test);
        }
    }
}
