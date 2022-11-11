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

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        Departamento departamento = new Departamento() { Id = 6, Nombre = "accenture" };
        List<Empleado> Empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado empleado1 = new Empleado(){ Apellido = "gomez", Nombre= "federico", Id= 1, legajo = 2244};
            Empleado empleado2 = new Empleado() { Apellido = "lopez", Nombre = "julian", Id = 2, legajo = 4344 };
            Empleado empleado3 = new Empleado() { Apellido = "perez", Nombre = "Romina", Id = 3, legajo = 8883 };


            Empleados.Add(empleado1);
            Empleados.Add(empleado2);
            Empleados.Add(empleado3);

            departamento.empleados = Empleados;

            if (departamento.empleados != null)
            {

                MessageBox.Show("se ha realizado la cara correctamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = departamento.empleados;
        }
    }
}
