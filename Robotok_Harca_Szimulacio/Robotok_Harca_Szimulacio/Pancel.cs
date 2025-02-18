using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    class Pancel
    {
        public string Nev { get; private set; }
        public int Vedelem { get; private set; }

        public Pancel(string nev, int vedelem)
        {
            Nev = nev;
            Vedelem = vedelem;
        }
    }
}
