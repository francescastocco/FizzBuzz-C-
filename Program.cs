using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            for (int i=1; i <= 100; i++) {
                result = i;
                if(i%3 == 0) {
                    result="Fizz";
                }
                Console.WriteLine(result);
            }
        }
    }
}
