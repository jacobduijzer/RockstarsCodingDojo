using System;
using System.Collections.Generic;

namespace FizzBuzz.Core
{
    public class FizzBuzzService
    {
        public string GetFizzBuzzForNumber(int number)
        {
            if(IsNumberOutOfBounds(number))
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }
            if (IsFizz(number) && CanDivideByFive(number)) return "FizzBuzz";
            if (IsFizz(number)) return "Fizz";
            if (CanDivideByFive(number)) return "Buzz";
            return number.ToString();
        }

        private static bool IsNumberOutOfBounds(int number)
        {
            return number < 1 || number > 100;
        }

        private static bool IsFizz(int number)
        {
            return  CanDivideByThree(number) || NumberContainsAThree(number);
        }

        private static bool NumberContainsAThree(int number)
        {
            return number.ToString().Contains("3");
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