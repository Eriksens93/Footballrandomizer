using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballrandomizer
{
     class Lag

    {
        public string Navn { get; set; }
        private List<Match> matches;
        //private Match match { get; set; }

        //constructor
        public Lag(string navn)
        {
            matches = new List<Match>();
            Navn = navn;
        }

        public  void LagLagene()
        {
            Lag Tyrkia = new Lag("Tyrkia");
            Lag Italia = new Lag("Italia");
            Lag Wales = new Lag("Wales");
            Lag Sveits = new Lag("Sveits");

            Lag Belgia = new Lag("Belgia");
            Lag Danmark = new Lag("Danmark");
            Lag Finland = new Lag("Finland");
            Lag Russland = new Lag("Russland");

            Lag Nederland = new Lag("Nederland");
            Lag NordMakedonia = new Lag("Nord-Makedonia");
            Lag Ukraina = new Lag("Ukraina");
            Lag Østerrike = new Lag("Østerrike");

            Lag England = new Lag("England");
            Lag Kroatia = new Lag("Kroatia");
            Lag Skottland = new Lag("Skottland");
            Lag Tsjekkia = new Lag("Tsjekkia");

            Lag Polen = new Lag("Polen");
            Lag Slovakia = new Lag("Slovakia");
            Lag Spania = new Lag("Spania");
            Lag Sverige = new Lag("Sverige");

            Lag Frankrike = new Lag("Frankrike");
            Lag Portugal = new Lag("Portugal");
            Lag Tyskland = new Lag("Tyskland");
            Lag Ungarn = new Lag("Ungarn");
        }
    }
}
