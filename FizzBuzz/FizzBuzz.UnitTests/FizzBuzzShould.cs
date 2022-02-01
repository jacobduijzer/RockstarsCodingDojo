using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.UnitTests
{

    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        public void GivenANumber_ReturnsNumberAsString(int number, string expected)
        {
            var unitUnderTest = new FizzBuzzGame();

            string result = unitUnderTest.GetFizzBuzzResultForInputNumber(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(6, "Fizz")]
        public void GivenANumber_WhenDivisibleBy3_ReturnsFizz(int number, string expected)
        {
            var unitUnderTest = new FizzBuzzGame();

            string result = unitUnderTest.GetFizzBuzzResultForInputNumber(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, "Buzz")]
        [InlineData(10, "Buzz")]
        public void GivenANumber_WhenDivisibleBy5_ReturnsBuzz(int number, string expected)
        {
            var unitUnderTest = new FizzBuzzGame();

            string result = unitUnderTest.GetFizzBuzzResultForInputNumber(number);

            Assert.Equal(expected, result);
        }

    }
}
