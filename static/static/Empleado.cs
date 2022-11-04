using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static1
{
    public class Empleado
{


        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static int _comision;

        public static int Comision
        {
            get { return _comision; }
            set { _comision = value; }
        }


        public Empleado(int id, string nombre, string apellido)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;

        }

        public Empleado() { }

    }
}
