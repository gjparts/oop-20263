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
        }
    }
}
