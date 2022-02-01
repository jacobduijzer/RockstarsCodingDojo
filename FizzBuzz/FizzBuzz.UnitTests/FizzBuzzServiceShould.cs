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
    }
}