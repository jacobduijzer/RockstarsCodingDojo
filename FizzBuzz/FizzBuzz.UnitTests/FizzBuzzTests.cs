using FizzBuzz.Core;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ServiceReturnsNumberOne()
        {
            // ARRANGE
            var service = new FizzBuzzService();
            
            // ACT
            var result = service.GetFizzBuzzForNumber(1);

            // ASSERT
            Assert.Equal("1",result);
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
    }
}