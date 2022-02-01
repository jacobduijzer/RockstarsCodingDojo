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
                if (IsFizz(x)) return "Fizz";
                if (IsBuzz(x)) return "Buzz";
                return x.ToString();
            }).ToArray();
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
        
        private bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}