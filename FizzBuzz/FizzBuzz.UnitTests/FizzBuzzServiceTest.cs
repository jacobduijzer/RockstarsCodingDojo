using NUnit.Framework;
using FluentAssertions;
using FizzBuzz.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz.UnitTests
{
    [TestFixture]
    internal class FizzBuzzServiceTest
    {
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")] // Divisible by 3 _and_ 5
        public void FizzBuzzTest(int input, string output)
        {
            // Arrange
            var service = new FizzBuzzService();

            // Act
            var result = service.FizzBuzz(input);

            // Assert
            result.Should().NotBeNull().And.Be(output);
        }

        [Test]
        public void  FizzBuzz_ReturnsTheNumber_ForOtherNumbers()
        {
            // Arrange
            var service = new FizzBuzzService(); // Duplicatation

            // Act
            var result = service.FizzBuzz(7);

            // Assert
            result.Should().Be("7");
        }
    }
}
