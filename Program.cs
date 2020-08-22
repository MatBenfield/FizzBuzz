using System;

namespace Benny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz test!");
            FizzBuzzer(100,3,5);
            Console.Read();
        }

        private static void FizzBuzzer(int n, int f, int b)
        {
            for (int i = 1; i <= n; i++)
            {
                string output = null;
                if (i % (f*b) == 0)
                {
                    output = " FizzBuzz";
                }
                else if (i % f == 0)
                {
                    output = " Fizz";
                }
                else if (i % b == 0)
                {
                    output = " Buzz";
                }
                Console.WriteLine(i + output);
            }
        }
    }
}
