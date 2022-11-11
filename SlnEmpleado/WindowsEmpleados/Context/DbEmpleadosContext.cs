using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados.adminDatos
{
    public class DbEmpleadosContext :DbContext
    {
        public DbEmpleadosContext() : base("DbEmpleadosKey"){}

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento>Departamentos { get; set; }


    }
}
