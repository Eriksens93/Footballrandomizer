using System;
using System.Collections.Generic;

namespace Footballrandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Em-grupper spår forskjellige utfall/randomizer. På poeng, vinn - uavgjort - tap og målforskjell.
            // Det er 6 grupper og hvert lag skal spille mot hverandre 1 gang hver, altså 3 kamper i gruppespillet.
            // De 2 øverste i hver gruppe ( A-F) går direkte videre samt de 4 beste treerne, som avgjøres på poeng eller målforskjell.
            // Det er altså mulig å få 0-9 poeng utenom 8, da man får 3 poeng for seier, 1 poeng for uavgjort og 0 poeng for tap.
            //  Gruppe A: Tyrkia, Italia,Wales, Sveits. Gruppe B: Belgia, Danmark, Finland, Russland. Gruppe C: Nederland, Nord-Makedonia, Ukraina, Østerrike. Gruppe D: England, Kroatia, Skottland Tsjekkia. Gruppe E: Polen, Slovakia, Spania, Sverige. Gruppe F:Frankrike, Portugal, Tyskland, Ungarn.
            // random, bool, variable navn.next range 1-9. s 

            // X - Putte alle lag i en liste, for så å dele lagene inn i grupper.
            // Hvert lag har 3 matcher, hver match kan inneholde 0-10 mål, resultat kan bli Vinn(3poeng) - uavgjort (1poeng) - tap (0poeng)
            // Hver gruppe er det 12 matcher

            
            

            Cup cup = new Cup();






        }
    }
}
