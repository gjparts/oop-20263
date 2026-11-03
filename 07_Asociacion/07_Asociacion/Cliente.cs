using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Asociacion
{
    public class Cliente
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Rtn { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        
        //Constructor
        public Cliente(string nombre, string rtn, string telefono, string correo)
        {
            this.Nombre = nombre;
            this.Rtn = rtn;
            this.Telefono = telefono;
            this.Correo = correo;
        }
    }
}
