using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public enum Answer
    {
        Fizz,
        Buzz,
        FizzBuzz,
        None
    }

    public class FizzBuzz
    {
        public static Answer Determine(int i)
        {
            if (i < 1 || i > 100)
            {
                throw new ArgumentException();
            }

            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;

            if (fizz && buzz)
            {
                return Answer.FizzBuzz;
            }
            else if (fizz)
            {
                return Answer.Fizz;
            }
            else if (buzz)
            {
                return Answer.Buzz;
            }
            else
            {
                return Answer.None;
            }
        }
    }
}
