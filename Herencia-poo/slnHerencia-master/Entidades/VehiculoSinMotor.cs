using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VehiculoSinMotor:Vehiculo
    {
        public VehiculoSinMotor(string color, string marca, string modelo, int cantidadRuedas, string rodado) : base(color, marca, modelo, cantidadRuedas)
        {
            Rodado = rodado;
        }
        public string Rodado { get; set; }
    }
}
