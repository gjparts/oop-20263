using _12_Herencia.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Herencia
{
    public class Estudiante : Persona //Heredamos de Persona
    {
        //Propiedades
        public string Cuenta { get; set; }
        public string Carrera { get; set; }

        //Constructor
        public Estudiante(string nombre, int edad, Genero genero,
            string cuenta, string carrera) : base(nombre,edad,genero)
        {
            //aqui se inicializa las propiedades de la clase Hijo
            this.Cuenta = cuenta;
            this.Carrera = carrera;
        }
        /*Observe que desde el constructor de la clase Hijo
        se ejecuta algo llamado base o sea la clase base la que
        se refiere a la clase Padre (super clase)
        Base es un metodo que ejecuta el constructor de la clase
        que estamos heredando, en este caso la clase Persona tiene
        un constructor con tres parametros: nombre, edad, genero.*/

        //Metodos

    }
}
