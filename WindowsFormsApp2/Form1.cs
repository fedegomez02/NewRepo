using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int total = 0;

            MessageBox.Show("ingresar 10 numeros menores a 1000");
            for (int i = 1; i <= 2; i++)
            {
                int numero = Convert.ToInt32(Interaction.InputBox("ingrese numero: ", "carga de numeros"));
                while (numero >= 100)
                {

                    MessageBox.Show(" numeros menores a 100 intente de nuevo");
                    numero = Convert.ToInt32(Interaction.InputBox("ingrese numero: ", "carga de numeros"));
                }
                total++;    
            }
            MessageBox.Show("total " + total);

        }
    }
}
