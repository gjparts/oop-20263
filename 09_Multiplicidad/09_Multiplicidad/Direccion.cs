using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiplicidad
{
    public class Direccion
    {
        //Campos privados
        private Barrio _colonia;

        //Propiedades
        public Barrio Colonia
        {
            get => this._colonia;
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Colonia en Direccion no puede ser null");
                else
                    this._colonia = value; //se acepta
            }
        }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Bloque { get; set; }
        public string Casa { get; set; }

        //Constructor
        public Direccion(Barrio colonia)
        {
            this.Colonia = colonia;
        }
    }
}
