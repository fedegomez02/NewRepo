using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;
        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { id = 1, Nombre = "fede", Apellido = "gomez", Direccion = "irigoyen", Telefono = "1328937", Email = "csbaskb", NroHistoriaClinica = 32324});
            pacientes.Add(new Paciente() { id = 2, Nombre = "carlos", Apellido = "lopezz", Direccion = "lalalnd", Telefono = "79087", Email = "csbaskb", NroHistoriaClinica = 9975 });
            pacientes.Add(new Paciente() { id = 3, Nombre = "rick", Apellido = "kansas", Direccion = "san luis", Telefono = "344434", Email = "csbaskb", NroHistoriaClinica = 43245 });
            return pacientes;

        }
        public static int Insertar(Paciente paciente) {


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
