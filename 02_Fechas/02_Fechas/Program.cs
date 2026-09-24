namespace _02_Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Manejo de Fechas en C#
            Existen diversos tipos para esto:
            1) DateTime     almacena fecha y hora
            2) DateOnly     almacena solo fecha
            3) TimeOnly     almacena solo hora
            Estos tipos existen a partir de .Net 6.0
            */

            //Obtener ls fecha.hora de la computadora
            //almacenarla en una variable
            DateTime hoy = DateTime.Now;
            Console.WriteLine(hoy);

            //impresion directa sin almacenar en variable
            Console.WriteLine(DateTime.Now);

            //reloj en pantalla
            /*while (true)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(500); //pausa de medio segundo
                Console.Clear();
            }*/

            //DateTime de forma nativa no se puede asignar a un valor nulo
            //DateTime x = null;
            //pero existe la posibilidad de saltar esta validacion
            //a traves del modificador ?
            DateTime? x = null;
            //esto no es una buena practica; pero puede servir
            //para solucionar algunos problemas o para generar mas.

            //tambien el saltarse la validacion de nulo permite
            //imprimir una variable sin ser asignada
            DateTime? z = null;
            Console.WriteLine(z);

            //en resumen: el operador ? permite declarar un objeto
            //cuyo valor no tiene referencia a la memoria (nulo o sin mem)

            //Crear un objeto de Fecha/Hora fijos
            //YYYY/MM/dd HH:mm:ss
            DateTime f1 = new DateTime(1982, 10, 15, 7, 33, 0);
            Console.WriteLine(f1);

            //YYYY/MM/dd
            DateTime f2 = new DateTime(2001, 9, 11);
            Console.WriteLine(f2);

            //solo fecha de la computadora
            DateOnly f3 = DateOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(f3);

            //solo una fecha fija
            DateOnly f4 = new DateOnly(1969, 6, 16);
            Console.WriteLine(f4);

            //solo la hora de la computadora
            TimeOnly h1 = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(h1);

            //establecer una hora fija
            //importante: el constructor se basa en formato de 24 horas
            TimeOnly h2 = new TimeOnly(20, 35, 12);
            Console.WriteLine(h2);

            //Imprimir DateTime utilizando formatos predefinidos
            DateTime f5 = DateTime.Now;
            Console.WriteLine($"Fecha corta: {f5.ToShortDateString()}");
            Console.WriteLine($"Fecha larga: {f5.ToLongDateString()}");
            Console.WriteLine($"Hora corta: {f5.ToShortTimeString()}");
            Console.WriteLine($"Hora larga: {f5.ToLongTimeString()}");

            //Imprimir DateTime utilizando su propia mascara
            Console.WriteLine($"Fecha con formato: {f5.ToString("yyyy/MM/dd hh:mm:ss tt")}");

            //Convertir un String a DateTime
            string str1 = "25/12/2026 21:45:19";
            DateTime f6 = DateTime.Parse(str1);
            Console.WriteLine(f6);
        }
    }
}
