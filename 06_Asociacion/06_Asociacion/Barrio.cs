using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion
{
    public class Barrio
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Municipio { get; set; }
        public string Ciudad { get; set; }
        
        //Constructor
        public Barrio(string nombre, string pais,
            string municipio, string ciudad)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Municipio = municipio;
            this.Ciudad = ciudad;
        }
    }
}
