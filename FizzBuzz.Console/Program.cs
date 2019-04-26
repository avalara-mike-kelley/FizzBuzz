using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var answer = Library.FizzBuzz.Determine(i);

                switch (answer)
                {
                    case Library.Answer.Fizz:
                    case Library.Answer.Buzz:
                    case Library.Answer.FizzBuzz:
                        var answerValue = Enum.GetName(typeof(Library.Answer), answer);
                        System.Console.WriteLine(answerValue);
                        break;
                    case Library.Answer.None:
                        System.Console.WriteLine(i);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
