using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    public class Empleado
    {
        //Campos privados: son variables que se usan para al acenar los valores
        //reales de las Propiedades privadas.
        //en C# se recomienda nombrarlas iniciando con un guion bajo y en minusculas (underscore prefix)
        private int _edad;
        private char _genero;
        private float _salario;
        private char _contrato;

        //Propiedades
        //toda propiedad que es public (+) lleva {get;set;}
        public string Nombre { get; set; }
        //las propiedades privadas (-) en C# se controlan a traves de algo conocido
        //como validador publico, que es donde vamos a aplicar las reglas de escritura
        public int Edad
        {
            get { return this._edad; } //retornar lo guardado en el campo privado
            set
            {
                //si el valor enviado cumple con la regla, se acepta sino se lanza una excepcion
                if (value >= 18)
                    this._edad = value; //se acepta y se escribe en el campo privado
                else
                    throw new ArgumentException("La edad debe de ser >= 18");
            }
        }
        public char Genero
        {
            get { return this._genero; }
            set
            {
                if(value == 'M' || value == 'F' || value == 'X')
                    this._genero = value; //se acepta
                else
                    throw new ArgumentException("Genero solo acepta alguno de los caracteres: M F X");
            }
        }
        public float Salario
        {
            get { return this._salario; }
            set
            {
                if (value >= 0)
                    this._salario = value; //se acepta
                else
                    throw new ArgumentException("Salario debe de ser >= 0");
            }
        }
        public char Contrato
        {
            get => this._contrato;  //puede ahorrar codigo en el get usando funcion de flecha
            set
            {
                if (value == 'T' || value == 'P')
                    this._contrato = value; //se acepta
                else
                    throw new ArgumentException("Contrato solo acepta los caracteres: T P");
            }
        }
        //Constructor
        public Empleado(string nombre, int edad, char genero, float salario, char contrato)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Salario = salario;
            this.Contrato = contrato;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("-------------------- Perfil del Empleado --------------------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Salario: {this.Salario}");
            Console.WriteLine($"Tipo de Contrato: {this.Contrato}");
        }
    }
}
