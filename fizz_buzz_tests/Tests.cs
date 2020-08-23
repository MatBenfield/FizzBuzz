using NUnit.Framework;

namespace fizz_buzz_tests
{
    public class Tests
    {

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void GivenValuesCalculatorReturnsFizz(int value)
        {
            var fbl = new fizz_buzz_lib.fizzbuzzer();
            var output = fbl.calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} Fizz");
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void GivenValuesCalculatorReturnsBuzz(int value)
        {
            var fbl = new fizz_buzz_lib.fizzbuzzer();
            var output = fbl.calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} Buzz");
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void GivenValuesCalculatorReturnsFizzBuzz(int value)
        {
            var fbl = new fizz_buzz_lib.fizzbuzzer();
            var output = fbl.calculator(value, 3, 5);

            Assert.AreEqual(output, $"{value} FizzBuzz");
        }
    }
}