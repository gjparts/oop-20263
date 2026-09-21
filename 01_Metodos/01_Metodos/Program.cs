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
        }

        //metodos (funciones)
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static double Cuadratica(double a, double b, double c)
        {
            double numerador = -b + Math.Sqrt(Math.Pow(b,2)-4*a*c);
            double denominador = 2 * a;
            return numerador / denominador;
        }
    }
}
