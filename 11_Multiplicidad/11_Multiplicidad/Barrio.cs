using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Multiplicidad
{
    public class Barrio
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Zona { get; set; }
        public string CodigoPostal { get; set; }

        //Constructor
        public Barrio(string nombre, string zona, string codigoPostal)
        {
            this.Nombre = nombre;
            this.Zona = zona;
            this.CodigoPostal = codigoPostal;
        }
    }
}
