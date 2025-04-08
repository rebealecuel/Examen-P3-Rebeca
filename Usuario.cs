using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_P3_Rebeca
{
    internal class Usuario
    {
        private static List<Usuario> Usu = new List<Usuario>();
        
        

        public Usuario() { }

        public List<Usuario> ObtenerUser()
        {
            return Usu;
        }

        public string User { get; set; }
        public string Password { get; set; }
    }
}
