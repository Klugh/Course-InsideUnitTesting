using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InsideUnitTesting.UnitTests
{
    public class FizzBuzzTestsImproved : IDisposable
    {
        private FizzBuzz fb;
        private string[] results;

        public FizzBuzzTestsImproved()
        {
            fb = new FizzBuzz();
            results = fb.getResultArrayForFizzBuzz(15);
        }

        public void Dispose()
        { }

        [Fact]
        public void FizzBuzz1_ShouldReturn1()
        {
            Assert.Equal("1", results[0].ToUpper());
        }

        [Fact]
        public void FizzBuzz2_ShouldReturn2()
        {
            Assert.Equal("2", results[1].ToUpper());
        }

        [Fact]
        public void FizzBuzz3_ShouldReturnFizz()
        {
            Assert.Equal("FIZZ", results[2].ToUpper());
        }

        [Fact]
        public void FizzBuzz4_ShouldReturn4()
        {
            Assert.Equal("4", results[3].ToUpper());
        }

        [Fact]
        public void FizzBuzz5_ShouldReturnBuzz()
        {
            Assert.Equal("BUZZ", results[4].ToUpper());
        }

        [Fact]
        public void FizzBuzz6_ShouldReturnFizz()
        {
            Assert.Equal("FIZZ", results[5].ToUpper());
        }

        [Fact]
        public void FizzBuzz7_ShouldReturn7()
        {
            Assert.Equal("7", results[6].ToUpper());
        }

        [Fact]
        public void FizzBuzz8_ShouldReturn8()
        {
            Assert.Equal("8", results[7].ToUpper());
        }

        [Fact]
        public void FizzBuzz9_ShouldReturnFizz()
        {
            Assert.Equal("FIZZ", results[8].ToUpper());
        }

        [Fact]
        public void FizzBuzz10_ShouldReturnBuzz()
        {
            Assert.Equal("BUZZ", results[9].ToUpper());
        }

        [Fact]
        public void FizzBuzz11_ShouldReturn11()
        {
            Assert.Equal("11", results[10].ToUpper());
        }

        [Fact]
        public void FizzBuzz12_ShouldReturnFizz()
        {
            Assert.Equal("FIZZ", results[11].ToUpper());
        }

        [Fact]
        public void FizzBuzz13_ShouldReturn13()
        {
            Assert.Equal("13", results[12].ToUpper());
        }

        [Fact]
        public void FizzBuzz14_ShouldReturn14()
        {
            Assert.Equal("FIZZBUZZ", results[14].ToUpper());
        }

        [Fact]
        public void FizzBuzz15_ShouldReturnFizzBuzz()
        {
            Assert.Equal("FIZZBUZZ", results[14].ToUpper());
        }

    }
}
