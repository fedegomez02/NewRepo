using static1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Empleado empleado1 = new Empleado(0, "fede", "gomez");

                MessageBox.Show(Empleado.Comision.ToString());

                Empleado empleado2 = new Empleado(1, "Carlos ", "perez");
                Empleado.Comision = 3000;

                MessageBox.Show(Empleado.Comision.ToString());

                Empleado empleado3 = new Empleado(2, "guillermo", "Francella");
                Empleado.Comision = 3500;

                MessageBox.Show(Empleado.Comision.ToString());

                Empleado empleado4 = new Empleado(1, "Ricardo ", "Darin");
                Empleado.Comision = 3700;

                MessageBox.Show(Empleado.Comision.ToString());
            }
    }
}
