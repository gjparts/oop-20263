namespace _04_CuentaAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                CuentaAhorro ah1 = new CuentaAhorro("Gerardo", "3213213213");
                //prueba del metodo get:
                Console.WriteLine($"Saldo de ah1: {ah1.Saldo}");
                //prueba de los metodos private set:
                ah1.Depositar(4000);
                Console.WriteLine($"Saldo de ah1: {ah1.Saldo}");
                ah1.Depositar(1000);
                ah1.Depositar(300);
                ah1.Depositar(50.50f);
                Console.WriteLine($"Saldo de ah1: {ah1.Saldo}");
                ah1.Retirar(800);
                Console.WriteLine($"Saldo de ah1: {ah1.Saldo}");
                //ah1.Depositar(-1000);
                //ah1.Retirar(90000);
                Console.WriteLine($"Saldo de ah1: {ah1.Saldo}");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
