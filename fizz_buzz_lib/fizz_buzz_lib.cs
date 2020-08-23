using System;

namespace fizz_buzz_lib
{
    public class fizzbuzzer
    {
        public string calculator(int i, int f, int b)
        {
            string output = null;
            if (i % (f * b) == 0)
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
            return (i + output);
        }
    }
}
