using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Multiplicidad
{
    public class Persona
    {
        //Propiedades
        public string Identidad { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public Direccion Direccion { get; set; } //asociacion por agregacion
        public Empresa EmpresaLabora { get; set; } //asociacion por agregacion
        public Mascota[] Mascotas { get; set; } //asociacion por agregacion
        public List<Diploma> Diplomas { get; set; } //asociacion por agregacion
        public Persona Conyuge { get; set; } //asociacion por agregacion
        public List<Persona> Hijos { get; set; } //asociacion por agregacion

        //Constructor
        public Persona(string identidad, string nombre, string telefono)
        {
            this.Identidad = identidad;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("********* Perfil de Persona *********");
            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Identidad: {this.Identidad}");
            Console.WriteLine($"Telefono: {this.Telefono}");

            //Direccion viene por agregacion, probablemente venga null
            if(this.Direccion != null)
            {
                Console.WriteLine("Direccion:");
                Console.WriteLine($"\tBarrio o Colonia: {this.Direccion.Colonia.Nombre}");
                Console.WriteLine($"\tCalle: {this.Direccion.Calle}");
                Console.WriteLine($"\tAvenida: {this.Direccion.Avenida}");
                Console.WriteLine($"\tBloque: {this.Direccion.Bloque}");
                Console.WriteLine($"\tCasa: {this.Direccion.Casa}");
            }

            //EmpresaLabora viene por agregacion, probablemente venga null
            if(this.EmpresaLabora != null)
            {
                Console.WriteLine("Empresa en donde labora:");
                Console.WriteLine($"\tNombre: {this.EmpresaLabora.Nombre}");
                Console.WriteLine($"\tTelefono: {this.EmpresaLabora.Telefono}");
                Console.WriteLine($"\tBarrio o Colonia: {this.EmpresaLabora.Direccion.Colonia.Nombre}");
            }

            //Mascotas viene por agregacion, probablemente venga null
            if(this.Mascotas != null)
            {
                //solo imprimir el rotulo Mascotas si el arreglo al menos tiene un item
                if(this.Mascotas.Length > 0)
                {
                    Console.WriteLine("Mascotas:");
                    foreach(Mascota item in this.Mascotas)
                    {
                        //si el item no es null pues se imprime
                        if(item != null)
                        {
                            Console.WriteLine($"\t{item.Nombre}, {item.Especie}");
                        }
                    }
                }
            }

            //Diplomas viene por agregacion, posiblemente sea null
            if(this.Diplomas != null)
            {
                if(this.Diplomas.Count() > 0)
                {
                    Console.WriteLine("Diplomas:");
                    foreach(Diploma item in this.Diplomas)
                    {
                        if(item != null) //Imprimir solo Diplomas que no sean null
                        {
                            Console.WriteLine($"\t{item.Nombre}, {item.Institucion}");
                        }
                    }
                }
            }

            //Datos del conyuge (tambien viene por agregacion)
            if(this.Conyuge != null)
            {
                Console.WriteLine("Conyuge:");
                Console.WriteLine($"\tNombre: {this.Conyuge.Nombre}");
                Console.WriteLine($"\tTelefono: {this.Conyuge.Telefono}");
            }

            //Hijos viene por agregacion, si viene null no se imprime
            if(this.Hijos != null)
            {
                if(this.Hijos.Count() > 0)
                {
                    Console.WriteLine("Hijos:");
                    foreach(Persona item in this.Hijos)
                    {
                        if( item != null)
                        {
                            Console.WriteLine($"\t{item.Nombre}");
                        }
                    }
                }
            }
        }
    }
}
 