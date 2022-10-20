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
    public partial class Casteos : Form
    {
        public Casteos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Existen 2 tipos de cast, implicito y explicito.
             En el primer caso vamos a ver que el casteo se realiza automaticamente
            en casos donde se convierte un tipo de dato(que sea del mismo tipo)de menor a mayor 
            Por ejemplo:
             */
            {
                long numero = 9;
                float numeroCambiado = numero;
            }
            /*
             En el segundo caso el casteo explicito consiste en el caso inverso, donde el tipo de dato
             es de mayor tamaño y se convierte a uno menor .En este caso el casteo se realiza de manera manual.
            Por ejemplo:
             
             */
            {
                float numero = 9;
                char numeroCambiado = (char)numero;
            }
            /*
              Tipos de metodos de conversion:
               existen metodos basados en codigo ya escrito que nos permite cambiar un tipo de dato a otro.
             existen varios como por ejemplo:
              */
            {
                int numero = 98798;
                Console.WriteLine(Convert.ToString(numero));
               
                String palabra = "7753";
                int numerito = (Convert.ToInt32(palabra)); 
                Console.WriteLine(numerito);
                
            }
            /*Aqui veremos un ejemplo con el form en  el que elaboramos una calculadora 
              de imc. 
             */
            double peso = Convert.ToDouble(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);
            double imc = peso / (altura*altura);
            MessageBox.Show("su imc es de " + imc);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

