using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class CamionCarga:Camion
    {
        public CamionCarga(string color, string marca, string modelo, int cantidadRuedas, int capacidadCarga, int cantAutosCargados) : base(color, marca, modelo, cantidadRuedas, capacidadCarga)
        {
            CantAutosCargados = cantAutosCargados;
        }
        public int CantAutosCargados { get; set; }
    }
}
