using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmMedico
    {
        public static List<Medico> medicos { get; set; }  
        public static List<Medico> Listar()
        {
             medicos = new List<Medico>();
          medicos.Add(new Medico() {id = 1,Nombre = "fede", Apellido = "gomez", Direccion = "irigoyen", Telefono = "1328937", Email = "csbaskb", Especialidad = "traumatologo", matricula = 2223 });
            medicos.Add(new Medico() { id = 2, Nombre = "raul", Apellido = "lopez", Direccion = "juana manso", Telefono = "1328937", Email = "c23444b", Especialidad = "pediatra", matricula = 3444 });
            medicos.Add(new Medico() { id = 3, Nombre = "flor", Apellido = "montes", Direccion = "cordoba", Telefono = "1328937", Email = "jjjeffsef", Especialidad = "Clinico", matricula = 2556 });
            return medicos;
            
        }

        public static List<Medico> Listar(string especialidad)
        {
            List<Medico> tempMedicos = new List<Medico> { };
            foreach (Medico medico in medicos)
            {
                if (medico.Especialidad == especialidad)
                {
                    tempMedicos.Add(medico);
                }
            }
            return tempMedicos;
        }

        public static int Insertar(Medico medico)
        {
            return 0;
        }

        public static int Eliminar(int id)
        {
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            return null;
        }
    }

}
