using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Asociacion
{
    public class Factura
    {
        //Campos privados
        private Producto _producto1;

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Producto Producto1
        {
            get => this._producto1;
            set
            {
                //Solo Producto1 va por Composicion
                if(value == null)
                    throw new ArgumentNullException("Producto1 en Factura es Obligatorio");
                else
                    this._producto1 = value; //se acepta
            }
        }
        //Producto2 al 4 son opcionales (al ser publicos en el diagrama van por Agregacion)
        public Producto Producto2 { get; set; }
        public Producto Producto3 { get; set; }
        public Producto Producto4 { get; set; }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto producto1)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Producto1 = producto1;
        }

        //Metodos
        public void Imprimir()
        {
            Console.WriteLine("*** Factura ***");
            Console.WriteLine($"Numero: {this.Numero}");
            Console.WriteLine($"Fecha: {this.Fecha.ToString("yyyy/MM/dd")}");

            //Si el cliente es null va como Consumidor Final
            //de lo contrario se imprime su Nombre y RTN
            if(this.Cliente == null)
                Console.WriteLine($"Cliente: Consumidor Final");
            else
            {
                Console.WriteLine($"Cliente: {this.Cliente.Nombre}");
                Console.WriteLine($"RTN: {this.Cliente.Rtn}");
            }

            //Tabla de productos
            Console.WriteLine("Producto\tPrecio");

            float suma = 0; //variable acumulador para ir sumando los productos

            //Producto1 al tener una regla que impide que sea null no es necesario validarlo
            Console.WriteLine($"{this.Producto1.Nombre}\t{this.Producto1.PrecioVenta}");
            suma += this.Producto1.PrecioVenta;

            //Producto2 al 4 estos si pueden ser null, por lo tanto solo se suman cuando
            //sean diferentes de null
            if(this.Producto2 != null)
            {
                Console.WriteLine($"{this.Producto2.Nombre}\t{this.Producto2.PrecioVenta}");
                suma += this.Producto2.PrecioVenta;
            }
            if (this.Producto3 != null)
            {
                Console.WriteLine($"{this.Producto3.Nombre}\t{this.Producto3.PrecioVenta}");
                suma += this.Producto3.PrecioVenta;
            }
            if (this.Producto4 != null)
            {
                Console.WriteLine($"{this.Producto4.Nombre}\t{this.Producto4.PrecioVenta}");
                suma += this.Producto4.PrecioVenta;
            }

            //Resultado
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15f, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma*1.15f, 2)}");
        }
    }
}
