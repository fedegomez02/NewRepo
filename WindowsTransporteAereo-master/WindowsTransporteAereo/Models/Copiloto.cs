using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public class Copiloto : Piloto
    {
        public Copiloto(string nombre, string apellido, string matricula) : base(nombre, apellido, matricula)
        {
        }
    }
}
