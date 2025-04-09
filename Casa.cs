using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_P3_Rebeca
{
    internal class Casa
    {
        
        

        public Casa() { }

        public Casa(int numCasa, string lugar)
        {
            NumCasa = numCasa;
            Lugar = lugar;
        }

        public int NumCasa { get; set; }
        public string Lugar { get; set; }
        
    }
}
