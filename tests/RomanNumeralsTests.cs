using NUnit.Framework;

namespace katas.tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        [TestCase(39, "XXXIX")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(160, "CLX")]
        [TestCase(200, "CC")]
        [TestCase(246, "CCXLVI")]
        [TestCase(300, "CCC")]
        [TestCase(500, "D")]
        [TestCase(789, "DCCLXXXIX")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1000, "M")]
        [TestCase(1066, "MLXVI")]
        [TestCase(1776, "MDCCLXXVI")]
        [TestCase(2000, "MM")]
        [TestCase(2421, "MMCDXXI")]
        [TestCase(3000, "MMM")]
        public void ShouldConvert(int input, string expected)
        {
            var result = RomanNumeralsConverter.Convert(input);

            Assert.That(result == expected);
        }

        [Test]
        public void ShouldOnlyConvertNumbersUpTo3999()
        {
            Assert.Throws<RomanNumeralsConverterException>(() => RomanNumeralsConverter.Convert(4000));
        }

        [Test]
        public void ShouldOnlyConvertNumbersLargerThan0()
        {
            Assert.Throws<RomanNumeralsConverterException>(() => RomanNumeralsConverter.Convert(0));
        }
    }
}