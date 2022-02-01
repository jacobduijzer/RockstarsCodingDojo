using System;
using System.Text;
using Xunit;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzServiceShould
    {
        [Fact]
        public void CreateNewInstance()
        {
            // ARRANGE
            var sut = new FizzBuzzService();
            
            //ACT
            string[] output = sut.PrintNumbers();

            // ASSERT
            Assert.NotEmpty(output);
        }

        [Fact]
        public void ShouldHaveExpectedNumberOfElements()
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();

            Assert.Equal(100, output.Length);
        }

        [Theory]
        [InlineData(3)]
        public void ShouldPrintFizzWhenDivisibleBy3(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("Fizz", output[outputIndex]);
        }
        
        [Theory]
        [InlineData(2)]
        public void ShouldPrintNumberWhenNotDivisibleBy3(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("2", output[outputIndex]);
        }
    }
}