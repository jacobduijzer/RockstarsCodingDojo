namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string FizzBuzz(int n)
        {
            if (DivisibleBy(n, 3)) return "Fizz";
            return "";
        }

        private bool DivisibleBy(int number, int divisor) => number % divisor == 0;
    }
}
