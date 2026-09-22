using System.Drawing;

namespace _01_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola UNAH");
            Console.WriteLine( Sumar(5,4));
            Console.WriteLine( Sumar(3,7));
            Console.WriteLine( Sumar(8, 11));
            Console.WriteLine(Cuadratica(1,4,1));
            Console.WriteLine(Cuadratica(2,3,1));
            //los metodos void solo se mandan a llamar
            //porque no retornan ningun valor
            Saludar();
            Despedirse(true);
            Despedirse(false);

            Console.WriteLine(Sumar(3,4,5));
            Console.WriteLine(Sumar(2.5,4.2));
            Console.WriteLine(Sumar(3.3f,4.8f)); //float es compatible con double

            //puede operar el valor retornado por dos o mas metodos
            double z = Sumar(4.5, 6.2) / Sumar(8.8, 1.4);
            Console.WriteLine($"El valor de z es {z}");

            //otro ejemplo: saquemos el promedio de tres cuadraticas
            double prom = (Cuadratica(1, 4, 1) + Cuadratica(2, 3, 1) + Cuadratica(1, 8, 1)) / 3.0;
            Console.WriteLine($"El promedio de las tres cuadraticas es {prom}");

            //el resultado de los metodos se puede usar en comparaciones
            if( Cuadratica(2,3,1) > 0 )
                Console.WriteLine("Es positivo");
            else
                Console.WriteLine("Es negativo");

            int[] arr1 = { 3, 4, 8, 1, -7, 100, 23 };
            ImprimirArreglo(arr1);
        }

        //metodos (funciones)
        //metodos que retornan un valor
        public static int Sumar(int a, int b)
        {
            return a + b;
        }
        public static int Sumar(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double Sumar(double a, double b)
        {
            return a + b;
        }
        /*Observe que tenemos varios metodos con el mismo nombre; pero
         con diferente firma a esto se le conoce como sobrecarga
        de metodos (method overload)
        La firma de un metodo esta conformada por su tipo de dato
        de retorno, su nombre y los tipos de dato de sus parametros.*/

        public static double Cuadratica(double a, double b, double c)
        {
            double numerador = -b + Math.Sqrt(Math.Pow(b,2)-4*a*c);
            double denominador = 2 * a;
            return numerador / denominador;
        }

        //metodos que no retornan algun valor
        public static void Saludar()
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Un gusto");
        }
        public static void Despedirse(bool enIngles)
        {
            if( enIngles == false )
                Console.WriteLine("Adios");
            else
                Console.WriteLine("Goodbye");
        }
        //metodo que recibe un arreglo de enteros como parametro y lo imprime
        public static void ImprimirArreglo(int[] arreglo)
        {
            //colorear el texto de entre 3 posibles colores
            Random r = new Random();
            int c = r.Next(1, 4); //numero al azar entre 1 y 3
            if (c == 1) Console.ForegroundColor = ConsoleColor.Yellow;
            if (c == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (c == 3) Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("-------------------------------");
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine($"Posicion {i}, Valor {arreglo[i]}");
            }

            Console.ResetColor();
        }
    }
}
