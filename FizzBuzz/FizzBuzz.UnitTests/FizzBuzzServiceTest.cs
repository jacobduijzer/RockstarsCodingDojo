using NUnit.Framework;
using FluentAssertions;
using FizzBuzz.Core;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    internal class FizzBuzzServiceTest
    {
        private FizzBuzzService _service = new FizzBuzzService();

        [TestCase(3, ExpectedResult="Fizz", Description="Divide by three returns Fizz")]
        [TestCase(5, ExpectedResult="Buzz", Description="Divide by five returns Buzz")]
        [TestCase(15, ExpectedResult="FizzBuzz",
          Description="Divide by three and five returns FizzBuzz")]
        [TestCase(13, ExpectedResult="Fizz", Description="Number contains 3 returns Fizz")]
        public string FizzBuzzTest(int input)
        {
            return _service.FizzBuzz(input);
        }

        [Test]
        public void  FizzBuzz_ReturnsTheNumber_ForOtherNumbers()
        {
            // Act
            var result = _service.FizzBuzz(7);

            // Assert
            result.Should().Be("7");
        }
    }
}
