using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion
{
    public class Direccion
    {
        //Campo privado
        private Barrio _barrio;

        //Propiedades
        public Barrio Barrio
        {
            get => this._barrio;
            set
            {
                //Asociacion por Composicion
                if(value == null)
                    throw new ArgumentNullException("Barrio en Direccion no puede ser null");
                else
                    this._barrio = value; //se acepta
            }
        }
        public string Calle { get; set; }
        public string Avenida { get; set; }
        public string Casa { get; set; }

        //Constructor
        public Direccion(Barrio barrio, string calle, string avenida, string casa)
        {
            this.Barrio = barrio;
            this.Calle = calle;
            this.Avenida = avenida;
            this.Casa = casa;
        }
    }
}
