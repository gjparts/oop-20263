namespace _06_Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Barrio b1 = new Barrio("R. Salamanca", "Honduras", "Cortes", "San Pedro Sula");
            Barrio b2 = new Barrio("Villa Florencia", "Honduras", "Cortes", "San Pedro Sula");

            Direccion dir1 = new Direccion(b1, "Carretera a el carmen", "N/A", "N/A");
            Direccion dir2 = new Direccion(b2, "Al fondo", "No recuerdo", "1033");
            Direccion dir3 = new Direccion(new Barrio("Guamilito", "Honduras", "Cortes", "SPS"), "7", "7-8", "N/A");

            Empresa e1 = new Empresa("2G", "Sistemas", dir1, "12341234");

            Cargo c1 = new Cargo("Desarrollador", Enum.JornadaLaboral.Mixta, e1, 100000);
            Cargo c2 = new Cargo("Representante Legal", Enum.JornadaLaboral.Mixta, e1, 15000);

            Estudiante es1 = new Estudiante("20012002049", "Gerardo", "Industrial", 18, dir2, c1);
            es1.Imprimir();

            Estudiante es2 = new Estudiante("20012002051", "Adonay", "Derecho", 19, dir3, c2);
            es2.Imprimir();
        }
    }
}
