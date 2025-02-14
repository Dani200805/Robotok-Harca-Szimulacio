using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    internal class Robot
    {
        public string Nev { get; set; }
        public int Hp { get; set; }
        public int Energia { get; set; }

        public Robot(string nev, int hp, int energia)
        {
            Nev = nev;
            Hp = hp;
            Energia = energia;
        }
    }
}
