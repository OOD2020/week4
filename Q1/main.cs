using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class main
    {
        static void Main(string[] args)
        {

            List<Team> teams = new List<Team>();
            //List<Player> Players = new List<Player>();

            Team SligoRovers = new Team("Sligo  Rovers");
            Team FinnHarps = new Team("Finn  Harps");
            Team GalwayUnited = new Team("Galway  United");
            Team DerryCity = new Team("Derry  City");
            Team Dundalk = new Team("Dundalk");

            teams.Add(SligoRovers);
            teams.Add(FinnHarps);
            teams.Add(GalwayUnited);
            teams.Add(DerryCity);
            teams.Add(Dundalk);
            Display(teams);


            SligoRovers.AddResult(Result.Win);
            FinnHarps.AddResult(Result.Loss);
            FinnHarps.AddResult(Result.Draw);
            GalwayUnited.AddResult(Result.Win);
            Dundalk.AddResult(Result.Loss);

            Display(teams);

            teams.Sort();
            teams.Reverse();
            Display(teams);

            List<Player> Players = new List<Player>();

            SligoRovers.Players.Add(new Player() { Name = "Ed McGinty", Position = "Goalkeeper" }); 
            SligoRovers.Players.Add(new Player() { Name = "John Mahon", Position = "Defender" }); 
            SligoRovers.Players.Add(new Player() { Name = "Ronan Coughlan", Position = "Forward" });
           
            Console.WriteLine("\nSligo Rovers Teamsheet"); 
            foreach (Player player in SligoRovers.Players)
            {
                //Console.WriteLine($"{player.Name} - {player.Position}"); 
                Console.WriteLine(player);
            }
        }
        static void Display(List<Team> teams)
        {
            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "POINTS", "WINS", "DRAWS", "LOSSES", "PLAYED");

            foreach (Team team in teams)
            {
                Console.WriteLine(team.DisplayTeamTable());
            }
        }
    }
}
