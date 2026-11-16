namespace _10_Multiplicidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Barrio ba1 = new Barrio("Guamilito", "Centro", "1234");
                Barrio ba2 = new Barrio("Salamanca", "Este", "21101");

                Direccion dir1 = new Direccion(ba1);
                dir1.Calle = "7";
                dir1.Avenida = "7 y 8";

                Direccion dir2 = new Direccion(ba2);
                dir2.Calle = "Carretera a El Carmen";
                dir2.Casa = "10";
                dir2.Bloque = "W";

                Empresa e1 = new Empresa("Credirapid", dir1, "12341234");

                Mascota m1 = new Mascota("Mandarino", "Gato");

                Persona per1 = new Persona("1111111111", "Gerardo Portillo", "99999999");
                per1.EmpresaLabora = e1;
                per1.Direccion = dir2;
                per1.Mascotas = new Mascota[]{ m1 }; //arreglo sin variable
                per1.Imprimir();

                Persona per2 = new Persona("7777777777777777", "Filomeno Colinas", "1234");
                per2.Imprimir();

                Persona per3 = new Persona("654321", "Estebancito Maravilla", "98761234");
                per3.Direccion = new Direccion(ba1); //la Direccion de per3 es un objeto sin variable
                per3.Direccion.Calle = "10";
                per3.Direccion.Avenida = "5";
                per3.Direccion.Casa = "1033";
                //Note que llenamos Calle, Avenida y Casa de per3 directamente desde su Direccion

                per3.EmpresaLabora = new Empresa("Ferreteria UNO", new Direccion(ba2), "76541234");
                per3.Imprimir();

                Persona per4 = new Persona("9876432", "Miguelito Jackson", "987643");
                Mascota abc = new Mascota("Bubbles", "Chimpance");
                Mascota m45 = new Mascota("Robber", "Perro");
                Mascota m123 = new Mascota("Edge", "Aguila");

                Mascota[] arreglo1 = { abc, m45, null, m123, new Mascota("Roy","Gallo") }; //el null es solo como ejemplo
                per4.Mascotas = arreglo1;
                per4.Imprimir();

                //Prueba de las nuevas propiedades
                Persona per5 = new Persona("77777777777", "Homero Simpson", "12341234");
                Barrio ba99 = new Barrio("Siempre viva","N/A","789");
                Direccion dir77 = new Direccion(ba99);
                dir77.Avenida = "No se";
                dir77.Calle = "Siempre viva";
                per5.Direccion = dir77;

                Barrio ba123 = new Barrio("Industrial Way", "Afuera", "111111");
                Direccion dir321 = new Direccion(ba123);

                per5.EmpresaLabora = new Empresa("Planta Nuclear de Springfield", dir321, "55555555");

                //Mascotas
                Mascota mas567 = new Mascota("Bola de Nieve III", "Gato");
                Mascota[] m678 = { mas567, new Mascota("Ayudante de Santa","Perro") };
                per5.Mascotas = m678;

                //Diplomas
                Diploma diploma1 = new Diploma("Curso de comer naranjas", "Primaria de Springfield");
                List<Diploma> diplomas123 = new List<Diploma>();
                diplomas123.Add(diploma1);
                diplomas123.Add(null); //prueba para ver si ignora null
                diplomas123.Add(new Diploma("Curso de Conducir Monorriel", "Vendedor"));
                per5.Diplomas = diplomas123;

                //Conyuge
                Persona per6 = new Persona("111111111111", "Marge Bouvier", "9876543");
                per5.Conyuge = per6;

                //Hijos
                Persona per7 = new Persona("876543", "Bartolomeo Simpson", "");
                Persona per8 = new Persona("245678", "Lisa Simpson", "");
                Persona per9 = new Persona("9876543", "Maggie Simpson", "");
                List<Persona> coleccion123 = new List<Persona>();
                coleccion123.Add(per7);
                coleccion123.Add(per8);
                coleccion123.Add(per9);
                per5.Hijos = coleccion123;

                per5.Imprimir();

                //Correlacion de información:
                //per6 tiene como Conyuge a per5
                per6.Conyuge = per5;
                //per6 tiene los mismos hijos que per5 (mismo matrimonio)
                per6.Hijos = per5.Hijos;
                per6.Direccion = per5.Direccion; //misma direccion si viven juntos
                per6.Imprimir();
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
