using System.Collections.Generic;

namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzForNumber(int number)
        {
            if (CanDivideByThree(number)) return "Fizz";
            return "1";
        }

        private static bool CanDivideByThree(int number)
        {
            return number % 3 == 0;
        }
    }
}