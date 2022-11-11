using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
   public class Departamento 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

       

        public Departamento(int Id, string Nombre, List<Empleado> lista)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.empleados = lista;
           
        }

        public Departamento()
        {
        }
        #region
        public List<Empleado> empleados { get; set; }
        #endregion
    }
}
