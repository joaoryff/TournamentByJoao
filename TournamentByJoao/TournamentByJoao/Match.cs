using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    public class Match
    {
        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        //public Double Score { get; set; }

        public Match(Team teamA, Team teamB)
        {
            TeamA = teamA;
            TeamB = teamB;
            //Score = score;
        }

        public Match()
        {
        }

        //public Team MatchScore2(Team T1, Team T2)
        //{

        //    Random random = new Random();
        //    Team min = T1.Rating <= T2.Rating ? T1 : T2;
        //    Team max = T1.Rating > T2.Rating ? T1 : T2;
        //    double result = random.NextDouble() * (T1.Rating + T2.Rating);

        //    return result <= min.Rating ? min : max; ;
        //}
        public Team MatchScore(Team T1, Team T2)
        {

            Random random = new Random();

            double result = random.NextDouble() * (T1.Rating + T2.Rating);

            return result <= T1.Rating ? T1 : T2; ;
        }


    }
}
