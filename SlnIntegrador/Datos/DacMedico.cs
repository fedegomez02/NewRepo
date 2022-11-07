using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class DacMedico
    {
       static List<Medico> medicos;
        public static List<Medico> Select()
        {
            medicos = new List<Medico>();
            

            return null;
        }
        public static List<Medico> Select(string especialidad)
        {
            return null;
        }

        public static int Insert(Medico medico)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Medico SelectById(int id)
        {
            return null;
        }
    }
}
