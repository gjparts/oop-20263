using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    public class Estudiante
    {
        //Campos privados
        private string _nombre;
        private string _cuenta;
        private string _dni;
        private char _genero;
        private int _edad;
        private float _promedio;
        private string _carrera;

        //Propiedades
        public string Nombre
        {
            get => this._nombre;
            set
            {
                if (value.Trim().Length >= 5)
                    this._nombre = value; //se acepta
                else
                    throw new ArgumentException("Nombre de tener al menos 5 caracteres.");
            }
        }
        public string Cuenta
        {
            get => this._cuenta;
            set
            {
                if (value.Trim().Length == 11)
                    this._cuenta = value; //se acepta
                else
                    throw new ArgumentException("Cuenta debe ser de 11 caracteres");
            }
        }
        public string DNI
        {
            get => this._dni;
            set
            {
                if (value.Trim().Length == 13)
                    this._dni = value; //se acepta
                else
                    throw new ArgumentException("DNI debe ser de 13 caracteres");
            }
        }
        public char Genero
        {
            get => this._genero;
            set
            {
                if (value == 'M' || value == 'F' || value == 'X')
                    this._genero = value; //se acepta
                else
                    throw new ArgumentException("Genero debe ser: M F X");
            }
        }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 12)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe ser >= 12");
            }
        }
        public float Promedio
        {
            get => this._promedio;
            set
            {
                if (value >= 0 && value <= 100)
                    this._promedio = value; //se acepta
                else
                    throw new ArgumentException("Promedio debe estar entre 0 y 100");
            }
        }
        public string Carrera
        {
            get => this._carrera;
            set
            {
                if (value.Trim().Length >= 10)
                    this._carrera = value; //se acepta
                else
                    throw new ArgumentException("Carrera debe ser de al menos 10 caracteres");
            }
        }
        //Constructor
        public Estudiante(string nombre, string cuenta, string dni, char genero,
            int edad, float promedio, string carrera)
        {
            this.Nombre = nombre;
            this.Cuenta = cuenta;
            this.DNI = dni;
            this.Genero = genero;
            this.Edad = edad;
            this.Promedio = promedio;
            this.Carrera = carrera;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("+-+-+-+-+-+-+ Perfil de Estudiante +-+-+-+-+-+-+");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Numero de Cuenta: {this.Cuenta}");
            Console.WriteLine($"DNI: {this.DNI}");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Promedio Global: {this.Promedio}");
            Console.WriteLine($"Carrera: {this.Carrera}");
        }
    }
}
