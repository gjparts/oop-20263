using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Mascota
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Especie { get; set; }

        //Constructor
        public Mascota(string nombre, string especie)
        {
            this.Nombre = nombre;
            this.Especie = especie;
        }
    }
}
