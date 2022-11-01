using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hidroavion: Avion
    {
        public Hidroavion(string color, string marca, string modelo, int cantidadRuedas, int cantPlazas, decimal cantLitrosTransp) : base(color, marca, modelo, cantidadRuedas, cantPlazas)
        {
            CantLitrosTransp = cantLitrosTransp;
        }
        public decimal CantLitrosTransp { get; set; }
    }
}
