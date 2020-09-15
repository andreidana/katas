using NUnit.Framework;

namespace katas.tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        StringCalculator stringCalculator;

        [SetUp]
        public void SetUp()
        {
            stringCalculator = new StringCalculator();
        }

        [Test]
        public void ShouldReturnZeroWhenPassedAnEmptyString()
        {
            Assert.AreEqual(stringCalculator.Add(""), 0);
        }

        [Test]
        public void ShouldReturnTheNumberWhenPassedStringWithOnlyOneNumber()
        {
            Assert.AreEqual(stringCalculator.Add("1"), 1);
        }

        [Test]
        public void ShouldReturnSumOfTwoNumbersWhenTheyArePassedAsCommaSeparated()
        {
            Assert.AreEqual(stringCalculator.Add("1,2"), 3);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("0,0,0", 0)]
        [TestCase("123,234,345", 702)]
        public void ShouldReturnSumOfAnyNumberOfInputParameters(string input, int expected)
        {
            Assert.AreEqual(stringCalculator.Add(input), expected);
        }

        [Test]
        public void ShouldAcceptNewLineAsDelimited()
        {
            Assert.AreEqual(stringCalculator.Add("1\n2,3\n4"), 10);
        }
    }
}