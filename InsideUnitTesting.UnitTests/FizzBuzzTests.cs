using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InsideUnitTesting.UnitTests
{
    public class FizzBuzzTests : IDisposable
    {
        private FizzBuzz fb;

        public FizzBuzzTests()
        {
            fb = new FizzBuzz();
        }

        public void Dispose()
        { }

        [Fact]
        public void ThreeIsDivisibleByThree_ShouldReturnTrue()
        {
            bool isDivisible = fb.isDivisibleByThree(3);
            Assert.True(isDivisible);
        }

        [Fact]
        public void FiveIsDivisibleByFive_ShouldReturnTrue()
        {
            bool isDivisible = fb.isDivisibleByFive(5);
            Assert.True(isDivisible);
        }

        [Fact]
        public void ResultForDivisibleByThree_ShouldReturnFizz()
        {
            string result = fb.getResultForNumber(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void ResultForDivisibleByFive_ShouldReturnBuzz()
        {
            string result = fb.getResultForNumber(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ResultForDivisibleByThreeAndFive_ShouldReturnFizzBuzz()
        {
            string result = fb.getResultForNumber(15);
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void ResultForNotDivisibleByThreeOrFive_ShouldReturnNumber()
        {
            string result = fb.getResultForNumber(4);
            Assert.Equal("4", result);
        }

        [Fact]
        public void FizzBuzzStringUpTo15()
        {
            string result = fb.getResultStringForFizzBuzz(15);
            Assert.Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
        }

        [Fact]
        public void FizzBuzzArrayUpTo15()
        {
            string[] results = fb.getResultArrayForFizzBuzz(15);

            Assert.Equal("1",        results[0].ToUpper());
            Assert.Equal("2",        results[1].ToUpper());
            Assert.Equal("FIZZ",     results[2].ToUpper());
            Assert.Equal("4",        results[3].ToUpper());
            Assert.Equal("BUZZ",     results[4].ToUpper());
            Assert.Equal("FIZZ",     results[5].ToUpper());
            Assert.Equal("7",        results[6].ToUpper());
            Assert.Equal("8",        results[7].ToUpper());
            Assert.Equal("FIZZ",     results[8].ToUpper());
            Assert.Equal("BUZZ",     results[9].ToUpper());
            Assert.Equal("11",       results[10].ToUpper());
            Assert.Equal("FIZZ",     results[11].ToUpper());
            Assert.Equal("13",       results[12].ToUpper());
            Assert.Equal("14",       results[13].ToUpper());
            Assert.Equal("FIZZBUZZ", results[14].ToUpper());
        }

    }
}
