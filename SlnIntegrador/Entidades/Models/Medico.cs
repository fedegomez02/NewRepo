
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico : PersonaClinica
    {
        public string Especialidad  { get; set; }

        public int matricula { get; set; }

        
        public Medico(int Id, string Nombre, string Apellido, string direccion, string Telefono, string Email, string especialidad, int matricula) : base(Id, Nombre, Apellido, direccion, Telefono, Email)
        {
            this.Especialidad = especialidad;
            this.matricula = matricula;
        }

        public Medico(){ }
    }
}
