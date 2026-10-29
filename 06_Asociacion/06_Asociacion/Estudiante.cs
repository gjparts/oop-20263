using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion
{
    public class Estudiante
    {
        //Campos Privados
        private int _edad;
        private Direccion _direccion;

        //Propiedades
        public string Cuenta { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public int Edad
        {
            get => this._edad;
            set
            {
                if (value >= 0)
                    this._edad = value; //se acepta
                else
                    throw new ArgumentException("Edad debe ser >= 0");
            }
        }
        public Direccion Direccion
        {
            get => this._direccion;
            set
            {
                //Asociacion por Composicion
                if(value == null)
                    throw new ArgumentNullException("Direccion en Estudiante no puede ser null");
                else
                    this._direccion = value; //se acepta
            }
        }
        public Cargo Trabajo { get; set; } //Asociacion por Agregacion (opcional)

        //Constructor
        public Estudiante(string cuenta, string nombre, string carrera, int edad,
            Direccion direccion, Cargo trabajo)
        {
            this.Cuenta = cuenta;
            this.Nombre = nombre;
            this.Carrera = carrera;
            this.Edad = edad;
            this.Direccion = direccion;
            this.Trabajo = trabajo;
        }

        public void Imprimir()
        {
            Console.WriteLine("************* Estudiante *************");
            Console.WriteLine($"Numero de cuenta: {this.Cuenta}");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Carrera: {this.Carrera}");
            Console.WriteLine($"Edad: {this.Edad}");

            //la Direccion al ser por Composicion siempre viene con
            //algun objeto, no necesita validar que venga null
            Console.WriteLine("Direccion:");
            Console.WriteLine($"\tBarrio: {this.Direccion.Barrio.Nombre}");
            Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
            Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
            Console.WriteLine($"\tMunicipio: {this.Direccion.Barrio.Municipio}");
            Console.WriteLine($"\tCiudad: {this.Direccion.Barrio.Ciudad}");
            Console.WriteLine($"\tPais: {this.Direccion.Barrio.Pais}");

            //El Trabajo de tipo Cargo esta por Agregacion, por lo tanto
            //existe posibilidad de que sea un valor null
            if(this.Trabajo != null)
            {
                Console.WriteLine("Informacion Laboral:");
                Console.WriteLine($"\tEmpresa: {this.Trabajo.Empresa.Nombre}");
                Console.WriteLine($"\tCargo: {this.Trabajo.Descripcion}");
                Console.WriteLine($"\tSalario: {this.Trabajo.Salario}");
                Console.WriteLine($"\tCiudad: {this.Trabajo.Empresa.Direccion.Barrio.Ciudad}");
            }
        }
    }
}
