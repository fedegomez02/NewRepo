using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public class Jett : TransporteAereo
    {
        public Jett(int velocidad, decimal costoHora, int capacidad, Tripulacion tripulacion) : base(velocidad, costoHora, capacidad)
        {
            Tripulacion = tripulacion;
        }
        public Tripulacion Tripulacion { get; set; }

    }
}
