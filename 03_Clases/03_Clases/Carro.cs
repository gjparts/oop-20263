using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    public class Carro
    {
        //Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public string Color { get; set; }
        //Constructores
        public Carro()
        {
            this.Marca = "No definida";
            this.Modelo = "No definido";
            this.Color = "No definido";
            this.Anio = 0;
        }
        public Carro(string marca, string modelo, string color, int anio)
        {
            this.Marca= marca;
            this.Modelo= modelo;
            this.Color = color;
            this.Anio = anio;
        }
        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("************ Carro ************");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Color: {this.Color}");
            Console.WriteLine($"Año: {this.Anio}");
        }
    }
}
