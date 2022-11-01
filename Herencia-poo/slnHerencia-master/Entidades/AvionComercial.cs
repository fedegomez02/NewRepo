using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AvionComercial : Avion
    {
        public AvionComercial(string color, string marca, string modelo, int cantidadRuedas, int cantPlazas, string aerolinea) : base(color, marca, modelo, cantidadRuedas, cantPlazas)
        {
            Aerolinea = aerolinea;
        }      
        public string Aerolinea { get; set; }
    }
}
