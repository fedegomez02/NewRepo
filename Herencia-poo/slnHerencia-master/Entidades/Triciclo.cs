using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Triciclo: VehiculoSinMotor
    {
        public Triciclo(string color, string marca, string modelo, int cantidadRuedas, string rodado) : base(color, marca, modelo, cantidadRuedas, rodado)
        {

        }
    }
}
