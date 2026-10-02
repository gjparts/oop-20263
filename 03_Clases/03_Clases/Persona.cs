using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    public class Persona
    {
        //Propiedades
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //Constructores
        /*Metodo Constructor
        Es aquel que permite asignar memoria a un objeto creado a partir
        de una clase, lo que hace este metodo es devolver una direccion de memoria.
        
        Caracteristicas:
        1) Son publicos (C#, JAVA, C++)
        2) En C# se debe nombrar al constructor igual que a la clase que pertenece
        3) No lleva tipo de dato ya que retorna un apuntador de memoria
        4) en C# una clase puede tener mas de un constructor siempre
           y cuando cada uno de ellos tenga una firma distinta
        5) Generalmente se usa los constructores para inicializar las
           propiedades con valores predeterminados; pero tambien se pueden
           usar para disparar eventos, otras acciones como por ejemplo
           conectar a una base de datos, registrar algo en una bitacora,
           realizar algun calculo complejo de inicio.*/
        public Persona()
        {
            //Constructor sin parametros
            //inicializar las propiedades con valores predeterminados
            this.Nombre = "No tiene";
            this.Edad = 0;
            this.Genero = 'X';
            this.DNI = "No tiene";
            this.FechaNacimiento = DateTime.Now;
        }
        public Persona(string nombre, int edad, char genero, string dni, DateTime fechaNacimiento)
        {
            //Constructor con parametros
            //En este caso es un constructor que llenara todas las propiedades, tambien
            //se le cono como constructor con todos los parametros
            //los parametros de un constructor se recomienda nombrarlos usando Camel Case o Snake Case
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.DNI = dni;
            this.FechaNacimiento = fechaNacimiento;
        }
        public Persona(string nombre, int edad)
        {
            //Constructor con dos parametros
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = 'X';
            this.DNI = "No tiene";
            this.FechaNacimiento = DateTime.Now;
        }

        //Metodos: son funciones declaradas dentro de una clase
        public void Imprimir()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*********** Perfil de la Persona ***********");
            Console.ResetColor();
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"Genero: {this.GetGeneroDescripcion()}");
            Console.WriteLine($"DNI: {this.DNI}");
            Console.WriteLine($"Fecha de Nacimiento: {this.FechaNacimiento}");
        }
        public bool EsMayorEdad()
        {
            if (this.Edad >= 18)
                return true;
            else
                return false;
        }
        public string GetGeneroDescripcion()
        {
            if (this.Genero == 'M') return "Masculino";
            if (this.Genero == 'F') return "Femenino";
            if (this.Genero == 'X') return "Otros";
            //Si llego hasta aqui es porque no se cumplio
            //ninguno de los if anteriores
            return "Genero no configurado en el sistema";
        }
    }
}