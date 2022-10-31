using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsPresentacion.Models
{
    public class Producto
    {
        public string Nombre { get; set; } 
        public string Descripcion { get; set; } 

        public decimal PrecioCosto { get; set; }

        public double margen { get; set; }

        public double Iva { get; set; }
        
        public decimal PrecioBruto { get {

              decimal  _PrecioBruto = PrecioCosto + Convert.ToDecimal(margen);
               return _PrecioBruto;
            } }
        public decimal PrecioVenta { get { 
            decimal _PrecioVenta  = PrecioBruto + Convert.ToDecimal(1 +Iva);
            return _PrecioVenta;
            } }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }





    }
}
