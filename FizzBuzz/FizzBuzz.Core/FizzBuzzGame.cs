namespace FizzBuzz.Core
{
    public class FizzBuzzGame
    {
        public string GetFizzBuzzResultForInputNumber(int number)
        {
            if (ShouldReturnFizzWhenDivisableBy3(number))
                return "Fizz";

            if (ShouldReturnBuzzWhenDivisableBy5(number))
                return "Buzz";

            return number.ToString();
        }

        private bool ShouldReturnFizzWhenDivisableBy3(int number) => number % 3 == 0;
        private bool ShouldReturnBuzzWhenDivisableBy5(int number) => number % 5 == 0;
    }
}
