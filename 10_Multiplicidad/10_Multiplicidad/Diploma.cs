using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplicidad
{
    public class Diploma
    {
        //Propiedades
        public string Institucion { get; set; }
        public string Nombre { get; set; }
        
        //Constructor
        public Diploma(string institucion, string nombre)
        {
            this.Institucion = institucion;
            this.Nombre = nombre;
        }
    }
}
