using System;

namespace Benny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz test!");  
            string output = null;
            for (int i = 1; i <= 100; i++)
            {
                output = FizzBuzzer(i,3,5);
                Console.WriteLine(output);
            }
            Console.Read();
        }

        public static string FizzBuzzer(int i, int f, int b)
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
                return(i + output);   
        }
    }
}
