using System;
using System.Collections.Generic;

namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzForNumber(int number)
        {
            if (CanDivideByThree(number) && CanDivideByFive(number)) return "FizzBuzz";
            if (CanDivideByThree(number)) return "Fizz";
            if (CanDivideByFive(number)) return "Buzz";
            return "1";
        }

        private static bool CanDivideByThree(int number)
        {
            return number % 3 == 0;
        }
        
        private bool CanDivideByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}