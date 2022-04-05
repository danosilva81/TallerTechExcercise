using System;
using TallerTechExcercise;
using Xunit;

namespace TallerTechExceicise.Tests
{
    public class CrazuCalculatorTest
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3 }, 123777)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 }, 777777)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 8, 9, 1, 2, 5, 6, 9, 9}, new int[] { 1, 2, 3, 4, 5, 6, 6}, 12345695780020)]
        public void SumReverseShouldReturnCorrectValues(int[] first, int[] second, long trueResult)
        {
            var calc = new CrazyCalulator();
            var result = calc.SumReverse(first, second);
            Assert.Equal(trueResult, result);
        }
    }
}
