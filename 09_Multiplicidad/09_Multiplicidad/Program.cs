namespace _09_Multiplicidad
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
			}
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
