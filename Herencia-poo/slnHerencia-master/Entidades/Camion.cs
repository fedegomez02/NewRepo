using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion:Vehiculo
    {
        public Camion(string color, string marca, string modelo, int cantidadRuedas, int capacidadCarga): base(color, marca, modelo, cantidadRuedas)
        {
            CapacidadCarga = capacidadCarga;
        }

        public int CapacidadCarga { get; set; }
       
    }
}
