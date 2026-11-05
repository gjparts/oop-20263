using System.Runtime.InteropServices.JavaScript;

namespace _08_Multiplicidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Gerardo","12341234123144","","");

            CategoriaProducto cate1 = new CategoriaProducto("Bebidas", "10");
            CategoriaProducto cate2 = new CategoriaProducto("Frutas", "1");
            CategoriaProducto cate3 = new CategoriaProducto("Limpieza", "24");
            CategoriaProducto cate4 = new CategoriaProducto("Churros", "17");

            Producto p1 = new Producto("Coca Cola 3L", cate1, 75);
            Producto p2 = new Producto("Sprite 2L", cate1, 55);
            Producto p3 = new Producto("Manzana", cate2, 9);
            Producto p4 = new Producto("Fabuloso Verde", cate3, 120);
            Producto p5 = new Producto("Dorito", cate4, 36);

            //arreglo de Productos para f1
            Producto[] coleccion1 = { p3 };
            Factura f1 = new Factura(1,DateTime.Now,c1, coleccion1);
            f1.Imprimir();

            Producto[] coleccion2 = { p2, p5, p3 };
            Factura f2 = new Factura(2, new DateTime(2026, 10, 31), null, coleccion2);
            f2.Imprimir();

            Factura f3 = new Factura(3, DateTime.Now, new Cliente("Mario", "777", "", ""), p4);
            f3.Producto2 = p1;
            f3.Imprimir();

            //Objeto volatil
            new Factura(4, DateTime.Now, null, p2).Imprimir();
        }
    }
}
