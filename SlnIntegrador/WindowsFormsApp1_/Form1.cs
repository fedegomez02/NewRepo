using Entidades.Ayudantes;
using Entidades.Models;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_
{
    public partial class Form1 : Form
    {
        
       
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrarMedicos_Click(object sender, EventArgs e)
        {
          

            GridPacientes.DataSource = AdmPaciente.Listar(); 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridPacientes.DataSource = AdmMedico.Listar();

            MedicosClinicosList.Items.Clear();
            List<Medico> medicosClinicos;
            medicosClinicos = AdmMedico.Listar("Clinico");
            foreach (Medico medico in medicosClinicos)
            {
                MedicosClinicosList.Items.Add(medico.Nombre + " " + medico.Apellido);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Habitacion habitacion in AdmHabitacion.Listar())
            {
                ListaHabitaciones.Items.Add("Número: " + habitacion.numero + ", estado: " + habitacion.Estado);
            }
        }

        private void BtnCalcularEdad_Click(object sender, EventArgs e)
        {
            Paciente paciente1 = new Paciente() { Nombre = "fede", Apellido = "gomez", FechaNacimiento = new DateTime(2002,1,2)};

            int edadpaciente = UtilidadesFechas.CalcularEdad(paciente1.FechaNacimiento);
            MessageBox.Show("el paciente " + paciente1.Nombre +" tiene "+ edadpaciente +" años");

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=DESKTOP-SHHSD54;Initial Catalog=msdb;Integrated Security=True";

            SqlConnection connection = new SqlConnection(cadenaConexion);
            connection.Open();  
        }
    }
}
