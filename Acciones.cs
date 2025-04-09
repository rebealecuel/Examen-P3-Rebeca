using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_P3_Rebeca
{
    internal class Acciones
    {
        Massobrecasa mas = new Massobrecasa();

        List<Massobrecasa> listahouse = new List<Massobrecasa>
        {
            new Massobrecasa(),
        };
        public List<Massobrecasa> mostrarcasa()
        { return listahouse; }

        public bool ActuaCasa(int numcasa, string lugar, string color, string patio, int ventanas)
        {
            try
            {
                var actuCasa = listahouse
            }
        }
        public bool Eliminarcasa(int numcasa)
        {
            try
            {
                var ElimCasa = listahouse.Find(x => x.NumCasa == numcasa);
                if (ElimCasa != null)
                {
                    listahouse.Remove(ElimCasa);
                    return true;
                }
                return false;
            }
            catch (Exception)
            { return false; }
            
        }
        public bool Agregarcasa(int numcasa, string lugar, string color, string patio, int ventanas)
        {
            try
            {
                var AgreCasa = listahouse.Find(x => x.NumCasa == numcasa);
                if (AgreCasa != null)
                {
                    listahouse.Add(new Massobrecasa(mas.NumCasa=numcasa,mas.Lugar=lugar,mas.Color=color,mas.Patio=patio,mas.Ventanas=ventanas));
                    return true;
                }
                return false;
            }
            catch (Exception)
            { return false; }
        }
    }
}
