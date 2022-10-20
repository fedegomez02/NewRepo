using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormFcs : Form
    {
        public FormFcs()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnImprimir2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }
        private void imprimir()
        {
            MessageBox.Show("Bienvenido");
        }
    }
}
