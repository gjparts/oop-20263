using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Asociacion
{
    public class Bateria
    {
        //Campos privados
        private Fabricante _marca;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                /*Observe en el Diagrama que la asociacion entre Bateria y Fabricante
                 es de tipo Composicion lo que quiere decir que es obligatoria.
                Para asegurar que la Marca de tipo Fabricante es obligatoria
                se hace la siguiente evaluacion del valor, si es null (sin memoria)
                pues no lo aceptamos, debe venir un objeto de tipo Fabricante
                para que sea aceptado el valor de la Marca.*/
                if (value == null)
                    //para reglas de Composicion usen la excepcion ArgumentNullException
                    throw new ArgumentNullException("Marca en Bateria no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public float MiliAmperios { get; set; }

        //Constructor
        public Bateria(Fabricante marca, float miliAmperios)
        {
            this.Marca = marca;
            this.MiliAmperios = miliAmperios;
        }
    }
}
