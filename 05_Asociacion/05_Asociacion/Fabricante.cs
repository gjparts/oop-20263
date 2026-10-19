using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Asociacion
{
    public class Fabricante
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Contacto { get; set; }

        //Constructor
        public Fabricante(string nombre, string pais, string contacto)
        {
            this.Nombre = nombre;
            this.Pais = pais;
            this.Contacto = contacto;
        }
    }
}
