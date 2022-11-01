using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bicicleta: VehiculoSinMotor
    {
        public Bicicleta(string color, string marca, string modelo, int cantidadRuedas, string rodado, bool cambios) : base(color, marca, modelo, cantidadRuedas, rodado)
        {
            Cambios = cambios;
        }
        public bool Cambios  { get; set; }
    }
}
