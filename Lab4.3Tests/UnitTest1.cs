using System;
using Xunit;
using Lab4._3_Program;

namespace Lab4._3Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 2)]
        [InlineData(6, 13)]
        [InlineData(11, 31)]
        [InlineData(19, 67)]
        [InlineData(25, 97)]
        public void PrimeTest1(int first, int expected)
        {
            PrimeNumbers num = new PrimeNumbers();
            int result = num.GetPrime(first);
            Assert.Equal(expected, result);
        }
    }
}
