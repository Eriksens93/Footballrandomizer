using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballrandomizer
{
    class Gruppe

    {
        //public char GruppeBokstav { get; set; }
        public List<Lag> GruppeListe;

        public Gruppe(Lag lag1, Lag lag2, Lag lag3, Lag lag4 )
        {
            GruppeListe = new List<Lag>();
            GruppeListe.Add(lag1);
            GruppeListe.Add(lag2);
            GruppeListe.Add(lag3);
            GruppeListe.Add(lag4);
        }

    }
}
