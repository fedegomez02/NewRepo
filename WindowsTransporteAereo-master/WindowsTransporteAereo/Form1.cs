using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsTransporteAereo.Models;

namespace WindowsTransporteAereo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJett_Click(object sender, EventArgs e)
        {
            Piloto piloto = new Piloto("Juan", "Perez", "P001");
            Copiloto copiloto = new Copiloto("Jose", "Rodriguez", "P002");
            Tripulacion tripulacion = new Tripulacion(piloto, copiloto);
            Azafata azafata = new Azafata("Juana", "Sanchez");
            tripulacion.AgregarAzafata(azafata);
            Jett jett = new Jett(150, (decimal)100.4, 5, tripulacion);
            MessageBox.Show(jett.Despegar("pista1"));
            MessageBox.Show(jett.Aterrizar("pista1"));
        }

        private void btnHelicoptero_Click(object sender, EventArgs e)
        {
            Helicoptero helicoptero = new Helicoptero(170, (decimal)7.5, 3, 6);
            MessageBox.Show(helicoptero.Despegar());
            MessageBox.Show(helicoptero.Aterrizar());
        }
    }
}
