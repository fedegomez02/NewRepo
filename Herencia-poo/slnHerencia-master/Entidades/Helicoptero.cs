using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Helicoptero : Vehiculo
    {
        public Helicoptero(string color, string marca, string modelo, int cantidadRuedas, int cantAspas): base(color, marca, modelo, cantidadRuedas)
        {
            CantAspas = cantAspas;
        }
        public int CantAspas { get; set; }
    }
}
