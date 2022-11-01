using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Sidecar: Moto
    {
        public Sidecar(string marca, string color, string modelo, int cantidadRuedas, int cilindrada) : base(marca, color, modelo, cantidadRuedas, cilindrada)
        {
        
        }
    }
}
