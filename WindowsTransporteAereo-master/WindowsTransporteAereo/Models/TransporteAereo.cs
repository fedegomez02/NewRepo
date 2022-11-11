using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public abstract class TransporteAereo
    {
        public TransporteAereo(int velocidad, decimal costoHora, int capacidad)
        {
            Velocidad = velocidad;
            CostoHora = costoHora;
            Capacidad = capacidad;
        }

        protected TransporteAereo(int velocidad, decimal costoHora)
        {
            Velocidad = velocidad;
            CostoHora = costoHora;
        }

        public int Capacidad { get; set; }

        public int Velocidad { get; set; }

        public decimal CostoHora { get; set; }

        public string Imprimir()
        {
            return "La capacidad es:" + Capacidad + "\nLa velocidad es:" + Velocidad + "\nEl costo por hora es:"+ CostoHora;
        }

        public string Despegar()
        {
            string velocidadCrucero = "";
            if(Velocidad > 160)
            {
                velocidadCrucero = "llego a la velocidad crucero.";
            }
            return "Despegando... " + velocidadCrucero;
        } 
        public string Despegar(string pista)
        {
            return "Despegando desde " + pista;
        }

        public string Aterrizar()
        {
            return "Aterrizando";
        }
        public string Aterrizar(string pista)
        {
            return "Aterrizando en " + pista;
        }
    }
}
