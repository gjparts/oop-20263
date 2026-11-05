using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Multiplicidad
{
    public class CategoriaProducto
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Pasillo { get; set; }

        //Constructor
        public CategoriaProducto(string nombre, string pasillo)
        {
            this.Nombre = nombre;
            this.Pasillo = pasillo;
        }
    }
}
