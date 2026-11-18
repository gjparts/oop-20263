using _12_Herencia.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Herencia
{
    public class Catedratico : Empleado
    {
        //Propiedades
        public string Profesion {  get; set; }

        //Constructor
        public Catedratico(string nombre, int edad, Genero genero,
            float salario, string cargo, string profesion)
            : base(nombre,edad,genero,salario,cargo)
        {
            this.Profesion = profesion;
        }
        /*A pesar de que la clase Empleado tiene un constructor sin parametros;
         pero tambien tiene uno con todos los parametros, aunque no me obliguen
        a usarlo yo he decidido para esta clase utilizar el constructor
        con todos los parametros a que quier llenar toda la informacion del
        Catedratico a traves del Empleado.*/

        //Metodos
        public void Educar()
        {
            Console.WriteLine($"Doy clases de mi profesion que es: {this.Profesion}");
        }
    }
}
