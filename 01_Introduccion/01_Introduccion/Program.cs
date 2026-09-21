namespace _01_Introduccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comentario de un renglon

            /*Comentario
             de varios
            renglones*/

            //a los comentarios se les conoce como pseudocodigo

            //Imprimir texto en la terminal o consola
            //Metodo WriteLine: imprime texto y pasa a la linea siguiente
            Console.WriteLine("Hola UNAH!");
            Console.WriteLine("20012002049 Gerardo Portillo");
            //puede agilizar esto escribiendo cw y presionando ENTER o TAB
            Console.WriteLine("Ingenieria");
            Console.WriteLine("Adios");

            //Metodo Write: imprime texto en la terminal y no pasa a la otra linea
            Console.Write("Pera");
            Console.Write("Manzana");
            
            //Puede imprimir un salto de linea aqui:
            Console.WriteLine();

            Console.Write("Sandia");
            Console.Write("Melon");
            Console.Write("Piña");

            //Uso de caracteres de escape
            //Caracter para salto de linea
            Console.WriteLine("\nLinea 1\nLinea 2\nLinea 3");
            Console.WriteLine("Honduras\n\nSan Pedro Sula\n\nCentro America");
            //puede tener varios saltos de linea:
            Console.WriteLine("\n\n\n\n\n\n\n\n\n");

            //Caracter para tabulacion
            Console.WriteLine("Nombre\tEdad\tGenero");
            Console.WriteLine("Josue\t43\tMasculino");
            Console.WriteLine("Irene\t42\tFemenino");
            Console.WriteLine("Viena\t18\tFemenino");
            Console.WriteLine("Antonio\t14\tMasculino");

            //Entonces, como imprimo un slash inverso?
            Console.WriteLine("Esto es un slash inverso: \\");
            //si la comilla doble se usa para cadena de texto
            //entonces como imprimo una comilla doble?
            Console.WriteLine("Esto es una comilla doble: \"");
            Console.WriteLine("Ramon Valdez alias \"Don Ramon\"");
        }
    }
}
