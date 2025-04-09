using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_P3_Rebeca
{
    internal class Massobrecasa : Casa
    {
        public Massobrecasa() { }

        public Massobrecasa(int numcasa, string lugar,string color, string patio, int ventanas)
            :base(numcasa,lugar)
        {
            Color = color;
            Patio = patio;
            Ventanas = ventanas;
        }

        public string Color { get; set; }
        public string Patio { get; set; }
        public int Ventanas { get; set; }
    }
}
