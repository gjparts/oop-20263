using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Clases.Enum;

namespace _03_Clases
{
    public class Instructor
    {
        //Campos privados
        private int _edad;

        //Propiedades
        public string Nombre { get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 18)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe ser >= 18");
            }
        }
        public Genero Genero { get; set; }
        public TipoContrato Contrato { get; set; }
        public TipoInstructor Tipo {  get; set; }
        //Constructores
        public Instructor(string nombre, int edad, Genero genero,
            TipoContrato contrato, TipoInstructor tipo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Contrato = contrato;
            this.Tipo = tipo;
        }
        public Instructor(string nombre, int edad, Genero genero)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Contrato = TipoContrato.Permanente;
            this.Tipo = TipoInstructor.General;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("-------------- Instructor --------------");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Tipo de Contrato: {this.Contrato}");
            Console.WriteLine($"Tipo de Instructor: {this.Tipo}");
        }
    }
}
