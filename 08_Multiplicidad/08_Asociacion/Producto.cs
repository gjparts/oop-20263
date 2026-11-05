using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Multiplicidad
{
    public class Producto
    {
        //Campos Privados
        private CategoriaProducto _categoria;

        //Propiedades
        public string Nombre { get; set; }
        public CategoriaProducto Categoria
        {
            get => this._categoria;
            set
            {
                if(value == null)
                    throw new ArgumentNullException("Categoria en Producto no puede ser null");
                else
                    this._categoria = value; //se acepta
            }
        }
        public float PrecioVenta { get; set; }

        //Constructor
        public Producto(string nombre, CategoriaProducto categoria, float precioVenta)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            this.PrecioVenta = precioVenta;
        }
    }
}
