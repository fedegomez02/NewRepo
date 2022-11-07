using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Director :Medico
    {

        public string PostGrado { get; set; }
        public Director(int id, string Nombre, string Apellido, string direccion, string Telefono, string Email, string especialidad, int matricula, string PostGrado) : base ( id,  Nombre,  Apellido,  direccion, Telefono, Email, especialidad, matricula)
        {

          this.PostGrado = PostGrado;
        }

    }
}
