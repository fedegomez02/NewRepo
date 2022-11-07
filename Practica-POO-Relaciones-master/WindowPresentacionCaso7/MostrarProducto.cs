using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caso7;
namespace WindowPresentacionCaso7
{
    public partial class MostrarProducto : Form
    {
        public MostrarProducto()
        {
            InitializeComponent();
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();
            producto1.Nombre = "Queso";
            producto1.Precio = Convert.ToDecimal(10.5);
            producto1.Categoria = new Categoria();
            producto1.Categoria.Nombre = "Alimento";

            Producto producto2 = new Producto();
            producto2.Nombre = "Jabón";
            producto2.Precio = 530;
            producto2.Categoria = new Categoria();
            producto2.Categoria.Nombre = "Limpieza";

            List<Producto> productos = new List<Producto>();

            productos.Add(producto1);
            productos.Add(producto2);
            int i = 1;
            foreach(Producto producto in productos)
            {
                MessageBox.Show($"Producto Nro: {i}\n Nombre: {producto.Nombre}\n Precio: {producto.Precio}" +
                    $"\nCategoria: {producto.Categoria.Nombre}");
                i++;
            }
        }
    }
}
