using FizzBuzz.Core;
using Xunit;
using Xunit.Sdk;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzTests : TestClass
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
        
    }
}