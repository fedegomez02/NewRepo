using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoDeportivo:Auto
    {
        public AutoDeportivo(string color, string marca, string modelo, int cantidadRuedas, int cantPuertas, int velMax) : base(color, marca, modelo, cantidadRuedas, cantPuertas)
        {
            VelMax = velMax;
        }
        public int VelMax { get; set; }
    }
}
