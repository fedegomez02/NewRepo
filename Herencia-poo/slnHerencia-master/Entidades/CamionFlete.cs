using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class CamionFlete:Camion
    {
        public CamionFlete(string color, string marca, string modelo, int cantidadRuedas, int capacidadCarga, int precioFlete) : base(color, marca, modelo, cantidadRuedas, capacidadCarga)
        {
            PrecioFlete = precioFlete;
        }
        public int PrecioFlete { get; set; }
    }
}

