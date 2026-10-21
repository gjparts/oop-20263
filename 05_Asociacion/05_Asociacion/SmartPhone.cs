using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_Asociacion.Enum;

namespace _05_Asociacion
{
    public class SmartPhone
    {
        //Campos privados
        private Fabricante _marca;
        private string _modelo;
        private Bateria _bateria;

        //Propiedades
        public Fabricante Marca
        {
            get => this._marca;
            set
            {
                //Relacion por Composicion
                if(value == null)
                    throw new ArgumentNullException("Marca en SmartPhone no puede ser null");
                else
                    this._marca = value; //se acepta
            }
        }
        public string Modelo
        {
            get => this._modelo;
            set
            {
                if (value.Trim().Length == 0)
                    throw new ArgumentException("Modelo en Smartphone no puede ir en blanco");
                else
                    this._modelo = value; //se acepta
            }
        }
        public Capacidad Almacenamiento { get; set; }
        public Capacidad Ram { get; set; }
        public Bateria Bateria
        {
            get => this._bateria;
            set
            {
                //Relacion por Composicion
                if (value == null)
                    throw new ArgumentNullException("Bateria en Smartphone no puede ser null");
                else
                    this._bateria = value; //se acepta
            }
        }
        /*Note que la relacion entre SmartPhone y Chip es por Agregacion, por lo tanto
         no es obligatorio que Chip1 y Chip2 tengan objeto: admiten null.*/
        public Chip Chip1 { get; set; }
        public Chip Chip2 { get; set; }

        //Constructor
        public SmartPhone(Fabricante marca, string modelo, Capacidad almacenamiento,
            Capacidad ram, Bateria bateria, Chip chip1, Chip chip2)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Almacenamiento = almacenamiento;
            this.Ram = ram;
            this.Bateria = bateria;
            this.Chip1 = chip1;
            this.Chip2 = chip2;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("------------- SmartPhone -------------");
            Console.WriteLine($"Marca: {this.Marca.Nombre}"); //referencia en cascada
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Almacenamiento en Gigas: {(int)this.Almacenamiento}");
            Console.WriteLine($"RAM en Gigas: {(int)this.Ram}");
            /*Note que para imprimir algo de la enumeracion Capacidad le coloque
             un (int) o sea una conversion implicita. Esto para imprimir
            el value en lugar del key de cada enumeracion, por ejemplo
            si la Capacidad es c64GB lo que va a imprimir es 64 que es el value
            asociado a c64GB en la enumeracion Capacidad.*/

            //La Bateria gracias a la regla que hicimos jamas va a ser null
            //por lo tanto la imprimos con tranquilidad:
            Console.WriteLine("Bateria:");
            Console.WriteLine($"\tMarca: {this.Bateria.Marca.Nombre}");
            Console.WriteLine($"\tMiliamperios: {this.Bateria.MiliAmperios}");

            /*Chip1 y Chip2 tienen una relacion por Agregacion, por lo tanto
             existe una alta probabilidad que sean nulos (null), por eso
            es necesario validar antes que si Chip1 o Chip2 NO son nulos
            solo asi podremos consultarlos, de lo contrario los ignoramos.*/
            if(this.Chip1 != null)
            {
                Console.WriteLine("Chip 1:");
                Console.WriteLine($"\tProveedor: {this.Chip1.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero Telefonico: {this.Chip1.NumeroTelefonico}");
            }

            if (this.Chip2 != null)
            {
                Console.WriteLine("Chip 2:");
                Console.WriteLine($"\tProveedor: {this.Chip2.Proveedor.Nombre}");
                Console.WriteLine($"\tNumero Telefonico: {this.Chip2.NumeroTelefonico}");
            }
        }
    }
}
