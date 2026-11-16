namespace _41_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglo (Array)
            Es una estructura de datos estatica, secuencial y homogenea
            la cual permite agreupar datos en una coleccion (multiplicidad)
            
           -> Estatica: por puede cambiar su tamaño y existe en una posicion
                        fija en la memoria principal.
                        Lo opuesto a estatico es dinamico.
           -> Secuencial: todos sus elementos se colocan dentro de la memoria
                          principal uno despues del otro.
                          Lo opuesto a secuencial es aleatorio.
           -> Homogenea: todos los elementos son del mismo tipo de dato.
                         Lo opuesto a homogeneo es heterogeneo.
            
            Todos los elementos en un arreglo en C#, C++, Java, Javascript se
            enumeran desde 0 hasta N-1, a esto se le conoce como Zero Indexing.
            
            El arreglo como estructura de datos, es recomendado su uso para volumenes
            de informacion pequeños, si necesita almacenar grandes volumenes de
            informacion se recomienda utilizar otras estructuras de datos como ser
            la Lista Vinculada, Diccionarios, Tablas Hash, Mapas de valores, Dataset,
            etc.

            Maneras de declarar arreglos en C#:
            1) Declarar el arreglo sin datos
            2) Declarar e inicializar el arreglo con datos predeterminados (default)
            3) Declarar e inicializar el arreglo prellenado con datos
             */

            //1) Declarar el arreglo sin datos
            int[] arreglo;
            /*[] se le conoce como brackets
            Este arreglo solo esta declarado; pero no inicializado por lo tanto
            no se puede utilizar ya que no le hemos asignado memoria.
            Si nota no le he dicho de que tamaño es.
            Mas adelante vamos a ver de que manera nos puede servir
            este tipo de arreglos: Esta declarado; pero no esta inicializado.*/

            /*2) Declarar e inicializar el arreglo con datos predeterminados (default)*/
            int[] arreglo1 = new int[5];
            /*Este arreglo ha sido declarado e inicializado por lo que
             se le ha asignado memoria RAM (new)
            Este arreglo se ha construido reservado 5 espacios de memoria
            cada uno va a guardar un int de 4 bytes.
            En C# cuando se inicializa un arreglo de esta forma, le asigna
            a cada uno de los elementos el valor CERO.*/

            //saber la longitud de un arreglo inicializado
            Console.WriteLine($"La longitud de arreglo1 es {arreglo1.Length}");

            //La propiedad Lenght de un arreglo es de tipo int
            //por lo tanto se puede tambien almacenar en una variable:
            int longitudX = arreglo1.Length;
            Console.WriteLine($"La longitud de arreglo1 es {longitudX}");

            //Que hay en cada elemento de arreglo1?
            //Leer cada elemento de un arreglo:
            Console.WriteLine(arreglo1[0]); //no que dentro del bracket va la posicion
            Console.WriteLine(arreglo1[1]);
            Console.WriteLine(arreglo1[2]);
            Console.WriteLine(arreglo1[3]);
            Console.WriteLine(arreglo1[4]);
            //lo que dentro del bracket se llama indice.

            //que pasa si por error leo un indice inexistente en el arreglo?
            //Console.WriteLine(arreglo1[5]);

            //Escribir manualmente los valores en un arreglo:
            arreglo1[2] = 60;
            arreglo1[4] = 100;
            arreglo1[3] = -777;

            //recorrer e imprimir un arreglo por medio de for:
            Console.WriteLine("-------------------------------------");
            for(int i = 0; i < arreglo1.Length; i++)
            {
                Console.WriteLine(arreglo1[i]);
            }
        }
    }
}
