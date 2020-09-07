using NUnit.Framework;

namespace katas.tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ShouldTransform()
        {
            var testLength = 15;
            string[] expected = {"1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Interpret(testLength);
            for (var i = 0; i < testLength; i++)
                Assert.That(result[0] == expected[0]);
        }
    }
}