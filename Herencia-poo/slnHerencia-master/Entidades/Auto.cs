using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto:Vehiculo
    {   
        public Auto(string color, string marca, string modelo, int cantidadRuedas, int cantPuertas ) : base( color, marca, modelo, cantidadRuedas)
        {
            CantPuertas = cantPuertas;
        }
        public int CantPuertas { get; set; }
    }
}
