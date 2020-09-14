using NUnit.Framework;

namespace katas.tests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void ShouldReturnZeroWhenPassedAnEmptyString()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(stringCalculator.Add(""), 0);
        }

        [Test]
        public void ShouldReturnTheNumberWhenPassedStringWithOnlyOneNumber()
        {
            var stringCalculator = new StringCalculator();

            Assert.AreEqual(stringCalculator.Add("1"), 1);
        }
    }
}