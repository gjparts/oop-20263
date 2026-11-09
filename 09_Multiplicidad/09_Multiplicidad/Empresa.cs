using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Empresa
    {
        //Campos privados
        private Direccion _direccion;

        //Propiedades
        public string Nombre { get; set; }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Direccion en Empresa no puede ser null");
                else
                    this._direccion = value; //se acepta
            }
        }
        public string Telefono { get; set; }

        //Constructor
        public Empresa(string nombre, Direccion direccion, string telefono)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
