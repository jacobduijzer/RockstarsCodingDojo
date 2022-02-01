// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string[] PrintNumbers()
        {
            return Enumerable.Range(0, 100).Select(x =>
            {
                if (IsFizzBuzz(x)) return "FizzBuzz";
                if (IsFizz(x)) return "Fizz";
                if (IsBuzz(x)) return "Buzz";
                return x.ToString();
            }).ToArray();
        }

        private bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0 || number.ToString().Contains("3");
        }
        
        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}