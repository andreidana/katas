using NUnit.Framework;

namespace katas.test
{
    [TestFixture]
    public class ScoreKeeperTests
    {
        [Test]
        public void ShouldReturnDefaultScoreAtTheStart()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreSame(scoreKeeper.GetScore(), "000:000");
        }
    }
}