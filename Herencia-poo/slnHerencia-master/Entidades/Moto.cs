using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        public Moto(string marca, string color, string modelo, int cantidadRuedas, int cilindrada): base(marca, color, modelo, cantidadRuedas)
        {
            Cilindrada = cilindrada;
        }
        public int Cilindrada { get; set; }
    }
}
