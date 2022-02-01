using NUnit.Framework;
using FluentAssertions;
using FizzBuzz.Core;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    internal class FizzBuzzServiceTest
    {
        private FizzBuzzService _service = new FizzBuzzService();

        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")] // Divisible by 3 _and_ 5
        [TestCase(13, "Fizz")]
        public void FizzBuzzTest(int input, string output)
        {
            // Act
            var result = _service.FizzBuzz(input);

            // Assert
            result.Should().NotBeNull().And.Be(output);
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
