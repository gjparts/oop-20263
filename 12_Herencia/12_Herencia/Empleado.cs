using _12_Herencia.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Herencia
{
    public class Empleado : Persona
    {
        //Propiedades        public float Salario {  get; set; }
        public string Cargo { get; set; }

        //Constructor
        public Empleado(string nombre, int edad, Genero genero,
            float salario, string cargo) : base(nombre, edad, genero)
        {
            this.Salario = salario;
            this.Cargo = cargo;
        }
        public Empleado() : base("No definido",0,Genero.Otros)
        {
            this.Salario = 0;
            this.Cargo = "No determinado";
        }
        //Observe que en Empleado puse un constructor sin parametros
        //y para constuir la super clase le pase valores default
        //y tambien a las propiedades de la clase hija le puse valores default
        //El hecho que la clase padre tenga un constructor no obliga
        //al hijo a tener el mismo tipo de constructor.

        //Metodos
        public void Trabajar()
        {
            Console.WriteLine($"Trabajo en el puesto de {this.Cargo}");
        }
    }
}
