using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Multiplicidad
{
    public class Factura
    {
        //Campos privados
        private Producto[] _productos;

        //Propiedades
        public int Numero {  get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public Producto[] Productos
        {
            get => this._productos;
            set
            {
                //validar que el arreglo de Producto tenga al menos un item
                //entonces si debe tener al menos un item, pues no debe permitir
                //que el arreglo sea null
                if( value == null )
                    throw new ArgumentNullException("Productos en Factura no puede ser null");
                else
                {
                    //el arreglo debe de tener al menos un item
                    if (value.Length == 0)
                        throw new ArgumentException("Productos en Factura debe tener al menos un item");
                    else
                    {
                        //el item 0 para Productos no ser permite que sea null
                        if (value[0] == null)
                            throw new ArgumentException("item 0 en Productos no puede ser null");
                        else
                            this._productos = value; //se acepta el arreglo
                    }
                }
            }
        }

        //Constructor
        public Factura(int numero, DateTime fecha, Cliente cliente, Producto[] productos)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Cliente = cliente;
            this.Productos = productos;
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

            //recorrer cada item del arreglo de Productos
            foreach(Producto item in this.Productos)
            {
                //ignorar cualquier item que sea nulo
                if(item != null)
                {
                    //se imprime y suma solo aquellos item que no sea nulos
                    Console.WriteLine($"{item.Nombre}\t{item.PrecioVenta}");
                    suma += item.PrecioVenta;
                }
            }

            //Resultado
            Console.WriteLine($"Subtotal: {Math.Round(suma,2)}");
            Console.WriteLine($"ISV 15%: {Math.Round(suma*0.15f, 2)}");
            Console.WriteLine($"Total: {Math.Round(suma*1.15f, 2)}");
        }
    }
}
