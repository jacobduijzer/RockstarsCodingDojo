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
        public void HaveExpectedNumberOfElements()
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();

            Assert.Equal(100, output.Length);
        }

        [Theory]
        [InlineData(3)]
        public void PrintFizzWhenDivisibleBy3(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("Fizz", output[outputIndex]);
        }
        
        [Theory]
        [InlineData(2)]
        public void PrintNumberWhenNotDivisibleBy3(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("2", output[outputIndex]);
        }
        
        [Theory]
        [InlineData(5)]
        public void PrintBuzzWhenDivisibleBy5(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("Buzz", output[outputIndex]);
        }
        
        [Theory]
        [InlineData(15)]
        public void PrintFizzBuzzWhenMultipleOf3Or5(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("FizzBuzz", output[outputIndex]);
        }
        
        [Theory]
        [InlineData(13)]
        public void PrintFizzWhenNumberContains3(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("Fizz", output[outputIndex]);
        }
        
        
        [Theory]
        [InlineData(51)]
        public void PrintFizzWhenNumberContains5(int outputIndex)
        {
            var sut = new FizzBuzzService();

            var output = sut.PrintNumbers();
            
            Assert.Equal("Buzz", output[outputIndex]);
        }
    }
}