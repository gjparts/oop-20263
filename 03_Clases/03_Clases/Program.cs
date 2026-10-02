namespace _03_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En C# las clases y objetos se nombran de acuerdo
                 a las siguientes convenciones de nombre:
                1) Use Pascal Case para nombrar sus clases.
                   o sea, la primer letra de cada palabra
                   va en mayusculas, ejemplos:
                    Mascota
                    Persona
                    CuentaBancaria
                    CarreraEstudianteUniversidad
                2) Utilice Camel Case para nombrar objetos y variables,
                   la primer letra de todo va en minuscula; pero para
                   cada palabra siguiente la primer letra va en
                   mayuscula. Ejemplos:
                    mascota1
                    personaX
                    cuentaBancaria98
                    carreraEstudianteUniversidad2
                3) Opcional: para objetos y variables tambien puede
                   usar Snake Case, aqui todo va en minusculas y
                   cada palabra se separa con un guion bajo. ejm:
                    mascota1
                    persona_x
                    cuenta_bancaria
                    carrera_estudiante_universidad
                   Esta notacion es mas popular en Python*/

            //Instanciar un nuevo objeto de clase Mascota
            Mascota m1 = new Mascota();
            //m1 es el objeto
            //Mascota es la clase

            //escribir valores a las propiedades de m1 (set)
            m1.Nombre = "Misifus";
            m1.Especie = "Gato";
            m1.Genero = 'M';
            m1.Edad = 3;

            //leer los valores de las propiedades de m1 (get)
            Console.WriteLine("Propiedades de m1:");
            Console.WriteLine($"Nombre: {m1.Nombre}");
            Console.WriteLine($"Especie: {m1.Especie}");
            Console.WriteLine($"Edad: {m1.Edad}");
            Console.WriteLine($"Genero: {m1.Genero}");
            Console.WriteLine($"Hash del objeto: {m1.GetHashCode()}");
            Console.WriteLine($"Ruta del objeto: {m1}");

            Persona per1 = new Persona();
            //leer los valores de las propiedades de per1
            per1.Imprimir();

            DateTime f1 = new DateTime(1982, 10, 15);
            Persona per2 = new Persona("Gerardo", 43, 'M', "123456789", f1);
            //leer los valores de las propiedades de per2
            per2.Imprimir();

            //usaré el constructor de dos parametros
            Persona per3 = new Persona("Irene", 42);
            //leer los valores de las propiedades de per3
            per3.Imprimir();

            Console.WriteLine($"per1 es mayor de edad? {per1.EsMayorEdad()}");
            Console.WriteLine($"per2 es mayor de edad? {per2.EsMayorEdad()}");
            if( per3.EsMayorEdad() == true )
                Console.WriteLine("per3 tiene el 25% de descuento");
        }
    }
}
