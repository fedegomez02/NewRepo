using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region constructor
        public Vehiculo(string color, string marca, string modelo, int cantidadRuedas)
        {
            Color = color;
            Marca = marca;
            Modelo = modelo;
            CantidadRuedas = cantidadRuedas;
        }
        #endregion

        #region propiedades
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CantidadRuedas { get; set; }
        #endregion
    }
}
