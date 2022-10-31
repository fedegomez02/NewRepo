using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacion.Models
{
    public class Factura
    {

       public string Tipo { get; set; }
       public string Numero { get; set; }

       public DateTime Fecha { get; set; }

        public string Cliente { get; set; }

        public string Direccion { get; set; }

        public string CondicionIva { get; set; }
        public string Detalle { get; set; }
        public string CondicionVenta { get; set; }
        public decimal Total { get; set; }



    }
}
