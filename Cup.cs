using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballrandomizer
{
    class Cup
    {
        public Gruppe GruppeA { get; set; }
        public Gruppe GruppeB { get; set; }
        public Gruppe GruppeC { get; set; }
        public Gruppe GruppeD { get; set; }
        public Gruppe GruppeE { get; set; }
        public Gruppe GruppeF { get; set; }

        public List<Gruppe> AlleGruppene = new List();



        public Cup()
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
            /*eksempel */
            Gruppe GruppeA = new Gruppe(Tyrkia, Italia, Wales, Sveits);
            Gruppe GruppeB = new Gruppe(Belgia, Danmark, Finland, Russland);
            Gruppe GruppeC = new Gruppe(Nederland, NordMakedonia, Ukraina, Østerrike);
            Gruppe GruppeD = new Gruppe(England, Kroatia, Skottland, Tsjekkia);
            Gruppe GruppeE = new Gruppe(Polen, Slovakia, Spania, Sverige);
            Gruppe GruppeF = new Gruppe(Frankrike, Portugal, Tyskland, Ungarn);
            SpillKamp();
        }

        public void SpillKamp()
        {
            Match kamp = new Match("Tyrkia", "Italia");
             List<Match> matches = new List<Match>();
             foreach (var lag in Gruppe.GruppeA.GruppeListe)
             {
                 //if (lag.Navn != "Tyrkia")
                 //{
                 //    matches.Add(new Match("Tyrkia", lag.Navn));
                 //    }
                 Console.WriteLine(lag);
             }
        }

    }
}
