using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CamionFrigorifico:Camion
    {
        public CamionFrigorifico(string color, string marca, string modelo, int cantidadRuedas, int capacidadCarga, decimal tempMinAlcanzada) : base(color, marca, modelo, cantidadRuedas, capacidadCarga)
        {
           TempMinAlcanzada = tempMinAlcanzada;
        }
        public decimal TempMinAlcanzada { get; set; }
    }
}
