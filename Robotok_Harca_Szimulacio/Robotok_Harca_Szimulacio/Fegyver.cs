using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    internal class Fegyver
    {
        public string Nev { get; set; }
        public int Sebzes { get; set; }
        public int Energiafogyasztas { get; set; }

        public Fegyver(string nev, int sebzes, int energiafogyasztas)
        {
            Nev = nev;
            Sebzes = sebzes;
            Energiafogyasztas = energiafogyasztas;
        }
    }
}
