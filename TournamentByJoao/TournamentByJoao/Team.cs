using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    public class Team
    {
        public string Name { get; set; }

        public double Rating { get; set; }

        public List<Player> Players { get; set; }



        public Team(string name, double rating)
        {
            Name = name;
            Rating = rating;
            Players = new List<Player>();
        }

        public Team()
        {
        }

        public string PopulateName(int i)
        {
            string[] name = new string[] { "A", "B", "C", "D", "E", "F", "G", "H" };

            return name[i];
        }

        public double PopulateTeamRating(List<Player> players)
        {
            // Depois fazer refactory
            double avg = 0;
            foreach (var item in players)
            {
                avg = avg + item.Rating;
            }
            avg = avg / 21;
            return avg;
        }

       

        public List<Team> CreateListTeams()
        {
            List<Team> listT = new List<Team>();



            for (int i = 0; i < 8; i++)
            {
                Player p = new Player();
                Team t = new Team();

                t.Name = PopulateName(i);
                t.Players = p.CreateListPlayers();
                t.Rating = PopulateTeamRating(t.Players);
                listT.Add(t);

            }

            return listT;
        }

        public override string ToString()
        {
            return $"Winner Name: {Name} Rating: {Rating} ";
        }
    }
}
