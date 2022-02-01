using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.UnitTests
{

    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        public void ReturnsNumberAsString(int number, string expected)
        {
            var unitUnderTest = new FizzBuzzGame();

            string result = unitUnderTest.GetFizzBuzzResultForInputNumber(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        public void GivenANumberWhichIsDivisibleBy3_ReturnsFizzAsString(int number, string expected)
        {
            var unitUnderTest = new FizzBuzzGame();

            string result = unitUnderTest.GetFizzBuzzResultForInputNumber(number);

            Assert.Equal(expected, result);
        }

    }
}
