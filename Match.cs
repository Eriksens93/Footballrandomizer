using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballrandomizer
{
    class Match
    {
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        private Random random = new Random();

        public Match(string homeTeam, string awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
            setgoals(HomeTeam, AwayTeam);
        }


        private void setgoals(string HomeTeam, string AwayTeam)
        {
            //random for å finne goals
            HomeGoals = random.Next(0, 10);
            AwayGoals = random.Next(0, 10);
            Console.WriteLine(HomeTeam + " " + HomeGoals + " - " + AwayGoals + " " + AwayTeam);
        }
        

    }
    
}
