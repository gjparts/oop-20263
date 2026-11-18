using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Herencia
{
    /*Note que al heredar de la clase Empleado no se nos exigio
     el constructor de la super clase.
    Esto ocurre cuando la super clase tiene definido un constructor
    SIN PARAMETROS; entonces la clase hija va a tomar dicho constructor
    de forma predeterminada y por eso no nos exige el constructor
    del padre.
    Internamente siempre se va a construir la clase padre.*/
    public class Practicante : Empleado
    {
        //Propiedades
        public int Meses { get; set; }

        //Constructor
        //Observe que en esta situacion no pusimo el base()
        //porque como Empleado tiene constructor sin parametros
        //pues no es necesario, a menos que Usted quiera usarlo.
        public Practicante(int meses)
        {
            this.Meses = meses;
        }
    }
}
