using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avioneta: Avion
    {
        public Avioneta (string color, string marca, string modelo, int cantidadRuedas, int cantPlazas, int peso) : base(color, marca, modelo, cantidadRuedas, cantPlazas)
        {
            Peso = peso;
        }
        public int Peso { get; set; }
    }
}
