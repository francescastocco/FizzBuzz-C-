using System;
using System.Collections;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter max number:");
            string maxNumberString = Console.ReadLine();
            int maxNumber = int.Parse(maxNumberString);

            for (int i = 1; i <= maxNumber; i++)
            {
                var result = new ArrayList();
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                if (i % 7 == 0)
                {
                    result.Add("Bang");
                }

                if (result.Count == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    var stringArray = result.Cast<string>().ToArray();
                    var resultString = string.Join("", stringArray);
                    Console.WriteLine(resultString);
                }
            }
        }
    }
}

//https://github.com/techswitch-learners/fizzbuzz-csharp/blob/master/FizzBuzz/Program.cs