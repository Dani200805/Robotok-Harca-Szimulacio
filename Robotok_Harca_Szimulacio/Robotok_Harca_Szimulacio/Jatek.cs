using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotok_Harca_Szimulacio
{
    class Jatek
    {
        public List<Fegyver> ElerhetoFegyverek { get; private set; }
        public List<Robot> Ellenfelek { get; private set; }
        public Robot JatekosRobot { get; private set; }
        public Random Random { get; private set; }

        public Jatek()
        {
            ElerhetoFegyverek = new List<Fegyver>();
            Ellenfelek = new List<Robot>();
            Random = new Random();
        }
    }
}
