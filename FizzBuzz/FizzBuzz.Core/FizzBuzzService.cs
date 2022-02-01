namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string FizzBuzz(int n)
        {
            if (DivisibleBy(n, 15)) return "FizzBuzz";
            if (DivisibleBy(n, 3)) return "Fizz";
            if (DivisibleBy(n, 5)) return "Buzz";

            return n.ToString();
        }

        private bool DivisibleBy(int number, int divisor) => number % divisor == 0;
    }
}
