using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoUrbana:Moto
    {
        public MotoUrbana(string marca, string color, string modelo, int cantidadRuedas, int cilindrada) : base(marca, color, modelo, cantidadRuedas, cilindrada)
        {
            
        }
    }
}
