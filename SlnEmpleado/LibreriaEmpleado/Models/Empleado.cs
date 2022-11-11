using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Empleado : Persona
    {
        public int legajo { get; set; }

        public Empleado(int legajo, int Id, string Nombre, string Apellido) : base(Id, Nombre, Apellido)
        {
            this.legajo = legajo;
           

        }

        public Empleado()
        {
        }
        #region propiedades de navegacion

        public virtual Departamento Departamento { get; set; }  
        #endregion
    }
}
