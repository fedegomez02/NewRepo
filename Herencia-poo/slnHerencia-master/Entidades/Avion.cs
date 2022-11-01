using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion:Vehiculo
    {
        public Avion(string color, string marca, string modelo, int cantidadRuedas, int cantPlazas): base(color, marca, modelo, cantidadRuedas)
        {
            CantPlazas = cantPlazas;
        }
        public int CantPlazas { get; set; }
    }
}
