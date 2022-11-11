using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsTransporteAereo.Models
{
    public class Tripulacion
    {
        public Tripulacion(Piloto piloto, Copiloto copiloto)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafatas = null;
        }

        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        public List<Azafata> Azafatas { get; set; }

        public void AgregarAzafata(Azafata azafata)
        {
            Azafatas.Add(azafata);
        }

        public void QuitarAzafata()
        {
            Azafatas.Clear();
        }
    }
}
