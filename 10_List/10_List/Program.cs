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

            //forma 3: usando el metodo Join de la clase String
            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n",lista1));
            /*string.Join retorna un string con todos los elementos de la
            coleccion dada, usando el separado definido en el primer parametro.
            En este caso puse \n para indicar que por cada item haga un salto
            de linea.*/

            //Obtener el tamaño de un List
            Console.WriteLine($"El tamaño de lista1 es {lista1.Count()}");

            //el metodo Count() de un List devuelve un numero entero, tambien
            //lo puede colocar dentro de una variable:
            int longitud = lista1.Count();
            Console.WriteLine($"El tamaño de lista1 es {longitud}");

            //List como coleccion Homogenea (todos sus items son del mismo tipo de dato)
            //Ejemplo: lista de numeros enteros
            List<int> lista2 = new List<int>();
            lista2.Add(5);
            lista2.Add(-900);
            lista2.Add(10000);
            lista2.Add(590);
            lista2.Add(-100);
            lista2.Add(0);
            lista2.Add(2);

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista2));

            //lista de string
            List<string> lista3 = new List<string>();
            lista3.Add("Manzana");
            lista3.Add("Pera");
            lista3.Add("Sandia");
            lista3.Add("Uva");
            lista3.Add("Mandarina");

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista3));

            //Leer un elemento dentro de una lista: en C# se hace como si
            //estuviera trabajando con arreglos, por medio del uso de brackets []
            Console.WriteLine($"item 0 en lista1: {lista1[0]}");
            Console.WriteLine($"item 4 en lista3: {lista3[4]}");
            Console.WriteLine($"item 2 en lista2: {lista2[2]}");

            //Eliminar un elemento dentro de un List que esta en determinada posicion:
            //eliminar el elemento 2 de la lista3
            lista3.RemoveAt(2);

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista3));

            //El metodo Add que ya usamos lo que hace es que agrega un nuevo item
            //al final de una lista:
            lista3.Add("Kiwi");
            lista3.Add("Melocoton");

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista3));

            //El metodo Insert en un List permite agregar un item en determinada posicion
            lista3.Insert(1, "Maracuya"); //inserta esta fruta en la posicion 1 en lista3

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista3));

            //Para sobreescribir un item de una lista, hagalo como en los arreglos:
            //reemplazar el item 2 de lista3 por el string Naranja
            lista3[2] = "Naranja";

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista3));

            //Tambien puede crear List prellenados
            List<string> lista4 = new List<string>(["Rojo","Verde","Azul","Amarillo","Gris"]);

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista4));

            List<double> lista5 = new List<double>([2.4,4.4,6.789,1.22,900.12,-700.2]);
            //al List prellenado lo puede seguir manipulando:
            lista5.Add(9.9);
            lista5.Add(3.1416);

            Console.WriteLine("---------------------------");
            Console.WriteLine(string.Join("\n", lista5));

        }
    }
}
