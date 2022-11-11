using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public class Piloto : Persona
    {
        public Piloto(string nombre, string apellido, string matricula) : base(nombre, apellido)
        {
            Matricula = matricula;
        }
        public string Matricula { get; set; }
    }
}
