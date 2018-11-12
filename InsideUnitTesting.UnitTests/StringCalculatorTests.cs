using System;
using System.Linq;
using Xunit;
using InsideUnitTesting;

namespace InsideUnitTesting.UnitTests
{
    public class StringCalculatorTests
    {
        [Fact]
        public void CreateNumString_TwoSimpleNumbers_ReturnsStringWithCommaBetween()
        {
			StringCalculator SUT = new StringCalculator();
			string result = SUT.CreateNumString(1, 2);
			Assert.Equal(string.Format("{0},{1}", 1, 2), result);
        }
    }
}
