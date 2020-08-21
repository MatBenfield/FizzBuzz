using System;

namespace Benny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz test!");

            FizzBuzzer();

            Console.Read();
        }

        private static void FizzBuzzer()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";
                if (i % 15 == 0)
                {
                    output = " FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    output = " Fizz";
                }
                else if (i % 5 == 0)
                {
                    output = " Buzz";
                }

                Console.WriteLine(i + output);
            }
        }
    }
}
