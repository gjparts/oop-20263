namespace _10_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Clase List
            Es una estructura de datos dinamica basada en la lista vinculada con la cual
            podemos crear una coleccion de objetos que puede cambiar de tamaño
            en tiempo real.
            -> al estar basada en la lista vinculada sus elementos se almacenan
               de forma aleatoria en la memoria principal.
            -> List es una clase nativa de C# por lo que no hay que importar nada extra
             */

            //List como coleccion Heterogenea (cada item puede tener un tipo distinto)
            List<object> lista1 = new List<object>();
            /*Observe que junto a List va el termino <object> a esto se le conoce
            como Generic y Generico y su proposito es indicar el tipo de dato
            de todos los items de esa lista.
            Si coloca object como Generico, en C# esto indica que dicha coleccion
            va a soportar cualquier tipo de dato, ya que el object es el antepasado
            comun de todos los tipos de datos en C#.*/

            //Agregar items a lista1
            lista1.Add("UNAH");
            lista1.Add(900.56);
            lista1.Add(2.25);
            lista1.Add("San Pedro Sula");
            lista1.Add(6.789f);
            lista1.Add(DateTime.Now);
            lista1.Add('X');
            lista1.Add(false);
            lista1.Add("Ingenieria");
            //Note que cada item tiene un tipo de dato diferente

            //Imprimir el contenido de un List
            //forma 1: usando un for tradicional
            for(int i = 0; i < lista1.Count(); i++)
            {
                Console.WriteLine(lista1[i]);
            }
            //List su longitud se obtiene por medio de Count() con parentesis
            //Los elementos se numeran desde 0 hasta Count()-1
            //Cada elemento se puede acceder a el como si fuese un arreglo usando brackets []

            //forma 2: usando foreach
            Console.WriteLine("---------------------------");
            foreach(object item in lista1)
            {
                Console.WriteLine(item);
            }
            //object es compatible con cualquier tipo de dato
        }
    }
}
