using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public  class PersonaClinica
    { 

        public int id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }


        public PersonaClinica(int Id, string Nombre, string Apellido, string direccion, string Telefono, string Email) {
           this.id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;   
            this.Direccion = Direccion; 
            this.Telefono = Telefono;   
            this.Email = Email; 

        
        }
        public PersonaClinica() { }

    }
}
