using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentByJoao
{
    public class Player
    {

        public double Rating { get; set; }

        public Player(double rating)
        {
            Rating = rating;
        }

        public Player()
        {
        }


        //public Player CreatePlayer()
        //{
        //    Random random = new Random();
        //    Player p = new Player(random.NextDouble() * (1 - 0.15) + 0.15);
        //    return p;
        //}  
        public void CreatePlayer()
        {
            Random random = new Random();
            Rating = (random.NextDouble() * (1 - 0.15) + 0.15);
        }
        public List<Player> CreateListPlayers()
        {

            List<Player> listPlayer = new List<Player>();

            for (int i = 0; i < 21; i++)
            {
                CreatePlayer();
                listPlayer.Add(new Player(Rating));
            }

            return listPlayer;
        }

    }
}
