using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Enfermero : PersonaClinica
    {
        public string Cuil { get; set; }
        public Enfermero(int Id, string Nombre, string Apellido, string direccion, string Telefono, string Email, string cuil) : base(Id, Nombre, Apellido, direccion, Telefono, Email)
        {
            Cuil = cuil;
        }
    }
}
