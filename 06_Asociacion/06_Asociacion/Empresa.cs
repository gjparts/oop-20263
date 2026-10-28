using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion
{
    public class Empresa
    {
        //Campo privado
        private Direccion _direccion;

        //Propiedades
        public string Nombre { get; set; }
        public string Rubro { get; set; }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                //Asociacion por Composicion
                if(value == null)
                    throw new ArgumentNullException("Direccion en Empresa no puede ser null");
                else
                    this._direccion = value; //se acepta
            }
        }
        public string Telefono { get; set; }

        //Constructor
        public Empresa(string nombre, string rubro, Direccion direccion, string telefono)
        {
            this.Nombre = nombre;
            this.Rubro = rubro;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
    }
}
