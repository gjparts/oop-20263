namespace _12_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante es1 = new Estudiante("Gerardo", 44, Enum.Genero.Masculino,
                "20012002049", "Ingenieria Industrial");
            Console.WriteLine("Datos de es1 ***********************");
            Console.WriteLine($"Nombre: {es1.Nombre}");
            Console.WriteLine($"Edad: {es1.Edad}");
            Console.WriteLine($"Genero: {es1.Genero}");
            Console.WriteLine($"Numero de cuenta: {es1.Cuenta}");
            Console.WriteLine($"Carrera: {es1.Carrera}");
            es1.Saludar();
            es1.Estudiar();
            /*Note que Estudiante al heredar de la clase Persona tiene
            las propiedades Nombre, Edad y Genero asi como agrega las
            propiedades Cuenta y Carrera que son propias del Estudiante.
            Al heredar de persona tambien obtiene el metodo Saludar()
            ya el metodo Estudiar es propio del Estudiante.*/

            Empleado em1 = new Empleado("Homer J. Simpson", 45, Enum.Genero.Masculino,
                20000, "Supervisor");
            Console.WriteLine("Datos de em1 ***********************");
            Console.WriteLine($"Nombre: {em1.Nombre}");
            Console.WriteLine($"Edad: {em1.Edad}");
            Console.WriteLine($"Genero: {em1.Genero}");
            Console.WriteLine($"Cargo: {em1.Cargo}");
            Console.WriteLine($"Salario: {em1.Salario}");
            em1.Saludar();
            em1.Trabajar();

            Empleado em2 = new Empleado();
            Console.WriteLine("Datos de em1 ***********************");
            Console.WriteLine($"Nombre: {em2.Nombre}");
            Console.WriteLine($"Edad: {em2.Edad}");
            Console.WriteLine($"Genero: {em2.Genero}");
            Console.WriteLine($"Cargo: {em2.Cargo}");
            Console.WriteLine($"Salario: {em2.Salario}");
            em2.Saludar();
            em2.Trabajar();

            Practicante pr1 = new Practicante(2);
            pr1.Nombre = "Estevancito Maravilla";
            pr1.Edad = 77;

            Console.WriteLine("Datos de pr1 ***********************");
            Console.WriteLine($"Nombre: {pr1.Nombre}");
            Console.WriteLine($"Edad: {pr1.Edad}");
            Console.WriteLine($"Genero: {pr1.Genero}");
            Console.WriteLine($"Cargo: {pr1.Cargo}");
            Console.WriteLine($"Salario: {pr1.Salario}");
            Console.WriteLine($"Meses de practica: {pr1.Meses}");
            pr1.Saludar();
            pr1.Trabajar();

            Catedratico c1 = new Catedratico("Gerardo", 44, Enum.Genero.Masculino,
                15000, "Docente por hora", "Ing. En Computación");
            Console.WriteLine("Datos de c1 ***********************");
            Console.WriteLine($"Nombre: {c1.Nombre}");
            Console.WriteLine($"Edad: {c1.Edad}");
            Console.WriteLine($"Genero: {c1.Genero}");
            Console.WriteLine($"Cargo: {c1.Cargo}");
            Console.WriteLine($"Salario: {c1.Salario}");
            Console.WriteLine($"Profesion: {c1.Profesion}");
        }
    }
}
