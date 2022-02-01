namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string FizzBuzz(int n)
        {
            if (DivisibleBy(n, 3)) return "Fizz";
            if (DivisibleBy(n, 5)) return "Buzz";
            return "";
        }

        private bool DivisibleBy(int number, int divisor) => number % divisor == 0;
    }
}
