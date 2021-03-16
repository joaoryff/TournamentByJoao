using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            Tournament campeonato = new Tournament();
            //Console.WriteLine(t.CreateListPlayers());
            //string a = "joao";
            //string b = "alex";
            //double ab = 0.25;
            //double bc = 0.59;
            //Team t = new Team(a, ab);
            //Team t2 = new Team(b, bc);
            //List<Team> lt = new List<Team>();
            //List<Player> lp = new List<Player>();
            //lt = t.CreateListTeams();


            //foreach (var item in lt)
            //{
            //    Console.WriteLine(item.Rating + item.Name);

            //}


            //Match m = new Match();
            //Team t3 = new Team();
            //t3 = m.MatchScore(t, t2);
            //Console.WriteLine(m.MatchScore(t, t2));

            Console.WriteLine(campeonato.GetWinner(t.CreateListTeams()));

        }
    }
}
