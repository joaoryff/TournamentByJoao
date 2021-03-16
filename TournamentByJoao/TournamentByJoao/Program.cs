using System;

namespace TournamentByJoao
{
    class Program
    {
        static void Main(string[] args)
        {
            Team t = new Team();
            Tournament campeonato = new Tournament();

            t = campeonato.GetWinner(t.CreateListTeams());
            //campeonato = campeonato.CreateTournament(t.CreateListTeams());



            //Console.WriteLine($"Team Name: {t.Name} Rating: {t.Rating} ");
            Console.WriteLine(t);
            foreach (var item in t.Players)
            {

                Console.WriteLine($" Player: {item.Rating}");
            }
            //Console.WriteLine(campeonato);
            //Console.WriteLine(t.ToString());


        }
    }
}
