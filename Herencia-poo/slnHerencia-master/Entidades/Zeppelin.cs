using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Zeppelin:Vehiculo
    {
        public Zeppelin( string color, string marca, string modelo, int cantidadRuedas, decimal longitud, decimal diametro): base(color, marca, modelo, cantidadRuedas)
        {
            Longitud = longitud;
            Diametro = diametro;
        }
        public decimal Longitud { get; set; }
        public decimal Diametro { get; set; }
    }
}
