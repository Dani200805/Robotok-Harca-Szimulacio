using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    internal class Pancel
    {
        public string Nev { get; set; }
        public int Vedelem_ertek { get; set; }
        public int Suly { get; set; }

        public Pancel(string nev, int vedelem_ertek, int suly)
        {
            Nev = nev;
            Vedelem_ertek = vedelem_ertek;
            Suly = suly;
        }
    }
}
