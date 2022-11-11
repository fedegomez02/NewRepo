using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public class Helicoptero : TransporteAereo
    {
        public Helicoptero(int velocidad, decimal costoHora, int capacidad, int cantidadAspas) : base(velocidad, costoHora, capacidad)
        {
            CantidadAspas = cantidadAspas;
        }
        public int CantidadAspas { get; set; }
    }
}
