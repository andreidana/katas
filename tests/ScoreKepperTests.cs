using NUnit.Framework;

namespace katas.test
{
    [TestFixture]
    public class ScoreKeeperTests
    {
        ScoreKeeper scoreKeeper;

        [SetUp]
        public void Setup()
        {
            scoreKeeper = new ScoreKeeper();
        }

        [Test]
        public void ShouldReturnDefaultScoreAtTheStart()
        {
            Assert.AreEqual(scoreKeeper.GetScore(), "000:000");
        }

        [Test]
        public void ShouldAdd1PointToTeamA()
        {
            scoreKeeper.scoreTeamA1();
            Assert.AreEqual(scoreKeeper.GetScore(), "001:000");
        }

        [Test]
        public void ShouldAdd1PointToTeamB()
        {
            scoreKeeper.scoreTeamB1();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:001");
        }

        [Test]
        public void ShouldAdd2PointsToTeamA()
        {
            scoreKeeper.scoreTeamA2();
            Assert.AreEqual(scoreKeeper.GetScore(), "002:000");
        }

        [Test]
        public void ShouldAdd2PointsToTeamB()
        {
            scoreKeeper.scoreTeamB2();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:002");
        }

        [Test]
        public void ShouldAdd3PointsToTeamA()
        {
            scoreKeeper.scoreTeamA3();
            Assert.AreEqual(scoreKeeper.GetScore(), "003:000");
        }

        [Test]
        public void ShouldAdd3PointsToTeamB()
        {
            scoreKeeper.scoreTeamB3();
            Assert.AreEqual(scoreKeeper.GetScore(), "000:003");
        }

        [Test]
        public void ShouldCorrectlyKeepScore()
        {
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();
            scoreKeeper.scoreTeamA1();

            scoreKeeper.scoreTeamA2();
            scoreKeeper.scoreTeamA2();
            scoreKeeper.scoreTeamA2();
            scoreKeeper.scoreTeamA2();

            scoreKeeper.scoreTeamB1();
            scoreKeeper.scoreTeamB1();
            scoreKeeper.scoreTeamB1();
            scoreKeeper.scoreTeamB1();
            scoreKeeper.scoreTeamB1();
            scoreKeeper.scoreTeamB1();

            scoreKeeper.scoreTeamB2();

            scoreKeeper.scoreTeamB3();
            scoreKeeper.scoreTeamB3();
            scoreKeeper.scoreTeamB3();

            Assert.AreEqual(scoreKeeper.GetScore(), "018:017");
        }
    }
}