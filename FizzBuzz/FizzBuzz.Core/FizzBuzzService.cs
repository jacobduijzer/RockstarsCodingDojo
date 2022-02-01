// ReSharper disable once CheckNamespace

using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzService
    {
        public string[] PrintNumbers()
        {
            return Enumerable.Range(0, 100).Select(x => IsFizz(x) ? "Fizz" : x.ToString()).ToArray();
        }

        private bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
    }
}