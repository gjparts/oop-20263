namespace _07_Matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio de la pizarra
            double a = 1, b = 2, c = 3;
            //forma 1: imprimir de un solo
            Console.WriteLine($"Resultado: {(4*a-c)/Math.Sqrt(b*b+a*a)}");
            //forma 2: imprimir de un solo elevando con Pow
            Console.WriteLine($"Resultado: {(4*a-c)/Math.Sqrt(Math.Pow(b,2)+Math.Pow(a,2))}");
            //forma 3: resolver por partes
            double numerador = 4 * a - c;
            double denominador = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));
            double resultado = numerador / denominador;
            Console.WriteLine($"Resultado: {resultado}");
            //forma 4: resolver por partes mas extenso
            double num = 4 * a - c;
            double interior_raiz = Math.Pow(b, 2) + Math.Pow(a, 2);
            double den = Math.Sqrt(interior_raiz);
            double r = num/ den;
            Console.WriteLine($"Resultado: {r}");
        }
    }
}
