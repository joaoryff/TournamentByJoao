using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    class Tournament
    {
        public double Result { get; set; }
        public List<Team> Teams { get; set; }
        //public List<Match> Matchs { get; set; }

        public Tournament(double result)
        {
            Result = result;
            Teams = new List<Team>();
            //Matchs = new List<Match>();
        }
        public Tournament()
        {

        }

        public Team GetWinner(List<Team> ListTeam)
        {
            Team tWinner = new Team();


            for (int i = 1; i < ListTeam.Count / 2; i++)
            {
                List<Team> tList = new List<Team>();

                for (int z = 0, j = ListTeam.Count - 1; i < ListTeam.Count / 2; i++, j--)
                {
                    Match m = new Match();
                    tWinner = m.MatchScore(ListTeam[i], ListTeam[j]);
                    tList.Add(tWinner);

                }

            }




            return tWinner;
        }
    }
}
