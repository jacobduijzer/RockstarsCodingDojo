using NUnit.Framework;
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
    }
}
