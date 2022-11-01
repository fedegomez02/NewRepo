using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoUrbano:Auto
    {
        public AutoUrbano(string color, string marca, string modelo, int cantidadRuedas, int cantPuertas, bool tieneAirbag) : base(color, marca, modelo, cantidadRuedas, cantPuertas)
        {
            TieneAirbag = tieneAirbag;
        }
        public bool TieneAirbag { get; set; }
    }
}
