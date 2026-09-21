namespace _00_Repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //imprimir una linea y pasar a la siguiente
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hola UNAH");
            /* Comentario
             * de
             * Varios renglones
            */
            //imprimir texto pero no pasar a la siguiente linea
            Console.Write("Imprimir texto y no cambiar de linea");
            Console.Write("Ingenieria");
            Console.Write("Honduras");

            //impresion de caracteres de escape
            //nueva linea \n
            Console.WriteLine("\n\n\n\n\nTexto");
            //tabulacion
            Console.WriteLine("Gerardo\tPortillo\tHonduras");

            //dar color al texto en la terminal
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Texto en color verde");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("texto color amarillo");

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("fondo magenta texto cyan");

            //regresar la consola a su color original
            Console.ResetColor();

            //Pausar la ejecucion del codigo en la termina
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(false); //false indica que no se imprima la tecla presionada

            //Limpiar el contenido de la terminal
            Console.Clear();

            //Imprimir texto sin tratamiento (Raw Text)
            Console.WriteLine(@"Este es un string sin ""Tratamiento""
por lo tanto puede declararse en
varias lineas
de texto
Raw text ignora caracteres especiales \n\t");

            //Interpolacion de variables
            int x = 15;
            Console.WriteLine($"El valor de x es {x}");
            double a = 2.5, b = 8.7;
            Console.WriteLine($"La suma de {a} mas {b} es {a+b}");

            //Sin interpolacion de variables
            Console.WriteLine("El valor de x es "+x);
            Console.WriteLine("La suma de "+a+" mas "+b+" es "+(a+b));

            //uso de variables es igual que en JAVA Y C++
            int edad = 43;
            double precio = 45.50;
            float area = 78.943f; //en JAVA y C# a los float se les pone f
            long numero = 123412341234L; //se recomienda ponerles una L


        }
    }
}
