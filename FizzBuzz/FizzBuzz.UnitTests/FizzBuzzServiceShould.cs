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
            sut.PrintNumbers();

            // ASSERT
        }
    }
}