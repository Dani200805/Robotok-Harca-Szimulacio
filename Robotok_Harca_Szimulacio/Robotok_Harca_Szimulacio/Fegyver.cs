using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    class Fegyver
    {
        public string Nev { get; private set; }
        public int Sebzes { get; private set; }

        public Fegyver(string nev, int sebzes)
        {
            Nev = nev;
            Sebzes = sebzes;
        }
    }
}
