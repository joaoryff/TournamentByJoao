using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    public class Tournament
    {
        public Team Result { get; set; }
        public List<Team> Teams { get; set; }
        //public List<Match> Matchs { get; set; }

        public Tournament(Team result)
        {
            Result = result;
            Teams = new List<Team>();
            //Matchs = new List<Match>();
        }
        public Tournament()
        {

        }

        public List<Team> GetTeamsWinners2(List<Team> ListTeam)
        {

            List<Team> tList = new List<Team>();

            for (int i = 0, j = ListTeam.Count - 1; i < ListTeam.Count / 2; i++, j--)
            {
                Team tWinner = new Team();
                Match m = new Match();
                tWinner = m.MatchScore(ListTeam[i], ListTeam[j]);
                tList.Add(tWinner);

                Console.WriteLine($"{ListTeam[i].Name} aganist  {ListTeam[j].Name}");
                Console.WriteLine($"Winner {tWinner.Name}");
            }

            return tList;
        }
        public List<Team> GetTeamsWinners(List<Team> ListTeam)
        {

            List<Team> tList = new List<Team>();

            for (int i = 0, j = 0; i < ListTeam.Count / 2; i++, j += 2)
            {
                Team tWinner = new Team();
                Match m = new Match();
                tWinner = m.MatchScore(ListTeam[j], ListTeam[j + 1]);
                tList.Add(tWinner);

                Console.WriteLine($"{ListTeam[j].Name} aganist  {ListTeam[j + 1].Name}");
                Console.WriteLine($"Winner {tWinner.Name}");
            }

            return tList;
        }

        public Team GetWinner(List<Team> ListTeam)
        {

            for (int i = 0; i < ListTeam.Count / 2; i++)
            {
                ListTeam = GetTeamsWinners(ListTeam);
            }
            Console.WriteLine($"Final Winner {ListTeam[0].Name}");

            return ListTeam[0];
        }

        public Tournament CreateTournament(List<Team> ListTeam)
        {
            Tournament tour = new Tournament();
            tour.Result = GetWinner(ListTeam);
            tour.Teams = ListTeam;

            return tour;
        }
    }
}
