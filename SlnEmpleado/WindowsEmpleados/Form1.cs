using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.AdminDatos;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = txtnombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.legajo = Convert.ToInt32(txtLegajo.Text);
            empleado.Id = Convert.ToInt32(txtId.Text);

            AdminEmpleado.Insertar(empleado);

            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource =AdminEmpleado.Listar();
            
        }
    }
}
