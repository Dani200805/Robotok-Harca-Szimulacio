using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    class Robot
    {
        public string Nev { get; private set; }
        public int Eletero { get; set; }
        public int Szint { get; private set; }
        public Fegyver Fegyver { get; set; }
        public Pancel Pancel { get; set; }

        public Robot(string nev, int szint, Fegyver fegyver, Pancel pancel)
        {
            Nev = nev;
            Szint = szint;
            Fegyver = fegyver;
            Pancel = pancel;
            Eletero = 100;
        }
    }
}
