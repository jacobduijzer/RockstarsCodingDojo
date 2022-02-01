namespace FizzBuzz.Core
{
    public class FizzBuzzGame
    {
        public string GetFizzBuzzResultForInputNumber(int number)
        {
            if (ShouldReturnFizzWhenDivisableBy3(number))
                return "Fizz";

            return number.ToString();
        }

        private bool ShouldReturnFizzWhenDivisableBy3(int number) => number % 3 == 0;
    }
}
