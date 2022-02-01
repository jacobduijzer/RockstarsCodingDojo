using System;
using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(7)]
        [InlineData(8)]
        public void ServiceReturnsValidNumber(int number)
        {
            // ARRANGE
            var service = new FizzBuzzService();
            
            // ACT
            var result = service.GetFizzBuzzForNumber(number);

            // ASSERT
            Assert.Equal(number.ToString(),result);
        } 

        [Fact]
        public void ServiceReturnsFizz()
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT
            var result = service.GetFizzBuzzForNumber(3);

            // ASSERT
            Assert.Equal("Fizz", result);
        }
        
        [Fact]
        public void ServiceReturnsBuzz()
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT
            var result = service.GetFizzBuzzForNumber(5);

            // ASSERT
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void ServiceReturnsFizzBuzz()
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT
            var result = service.GetFizzBuzzForNumber(15);

            // ASSERT
            Assert.Equal("FizzBuzz", result);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        public void ServiceThrowsArgumentOutOfRangeException(int number)
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT & ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => service.GetFizzBuzzForNumber(number));
        }

        [Fact]
        public void ServiceReturnsFizzWhenNumberContainsThree()
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT
            var result = service.GetFizzBuzzForNumber(13);

            // ASSERT
            Assert.Equal("Fizz", result);
        }
        
        [Fact]
        public void ServiceReturnsBuzzWhenNumberContainsFive()
        {
            // ARRANGE
            var service = new FizzBuzzService();

            // ACT
            var result = service.GetFizzBuzzForNumber(52);

            // ASSERT
            Assert.Equal("Buzz", result);
        }
    }
}