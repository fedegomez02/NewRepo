using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Cliente : Persona
    {

        public string Cuit { get; set; }

        public string Telefono { get; set; }


        public Cliente(string cuit,string telefono, int Id, string Nombre, string Apellido) : base(Id, Nombre, Apellido)
        {
            this.Cuit = cuit;
            this.Telefono = telefono;
        }
    }
}
