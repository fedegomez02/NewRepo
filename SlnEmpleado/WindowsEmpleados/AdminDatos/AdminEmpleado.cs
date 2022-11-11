using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.adminDatos;

namespace WindowsEmpleados.AdminDatos
{
    public static class AdminEmpleado
    {
        public static DbEmpleadosContext context = new DbEmpleadosContext();

        public static int Insertar(Empleado empleado)
        {
            context.Empleados.Add(empleado);
            int filasafectadas = context.SaveChanges();
            return filasafectadas;

        }

        public static List<Empleado> Listar()
        {
            List<Empleado> lista = new List<Empleado>() { };
            lista = context.Empleados.ToList();
            return lista;

        }


    }
}
