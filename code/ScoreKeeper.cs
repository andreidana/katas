/*We need software to deliver the proper data to the scoreboard for a basketball team.
Unfortunately the people using our software are not the brightest lights under the sun,
so they need six buttons (each team can score either 1, 2 or 3 points with a single shot).

Your Task
Write a class ScoreKeeper which offers following methods:

void scoreTeamA1()
void scoreTeamA2()
void scoreTeamA3()
void scoreTeamB1()
void scoreTeamB2()
void scoreTeamB3()
String getScore()
Rules
The returned String always has seven characters. An example would be 000:000*/
using System;

namespace katas
{
    public class ScoreKeeper
    {
        private int teamAScore;
        private int teamBScore;

        public ScoreKeeper()
        {
            teamAScore = 0;
            teamBScore = 0;
        }

        public string GetScore()
        {
            var aTeamScoreString = teamAScore.ToString().PadLeft(3, '0');
            var bTeamScoreString = teamBScore.ToString().PadLeft(3, '0');
            return $"{aTeamScoreString}:{bTeamScoreString}";
        }


        public void scoreTeamA1()
        {
            teamAScore += 1;
        }

        public void scoreTeamA2()
        {
            teamAScore += 2;
        }

        public void scoreTeamA3()
        {
            teamAScore += 3;
        }

        public void scoreTeamB1()
        {
            teamBScore += 1;
        }

        public void scoreTeamB2()
        {
            teamBScore += 2;
        }

        public void scoreTeamB3()
        {
            teamBScore += 3;
        }
    }
}