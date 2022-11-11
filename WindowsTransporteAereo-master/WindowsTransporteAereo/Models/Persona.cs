using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public abstract class Persona
    {
        protected Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
