using System;
using Xunit;

namespace InsideUnitTesting.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Adding1And2_ShouldReturn3()
        {
			//Setup
			Calculator calc = new Calculator();
			int result = calc.Sum(1, 2);
			Assert.Equal(3, result);
        }
    }
}
 