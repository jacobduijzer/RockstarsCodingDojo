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
        [Test]
        public void ThreeShouldReturnFizz()
        {
            // Arrange
            var service = new FizzBuzzService();

            // Act
            var result = service.FizzBuzz(3);

            // Assert
            result.Should().NotBeNull().And.Be("Fizz");
        }

        [Test]
        public void FiveShouldReturnBuzz()
        {
            // Arrange
            var service = new FizzBuzzService();

            // Act
            var result = service.FizzBuzz(5);

            // Assert
            result.Should().NotBeNull().And.Be("Buzz");
        }
    }
}
