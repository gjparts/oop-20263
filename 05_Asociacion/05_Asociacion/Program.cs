namespace _05_Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Pruebas
                //Primero vamos a crear objetos de las clases no dependientes
                Fabricante lg = new Fabricante("LG Chemical", "Korea", "algun koreano");
                Fabricante samsung = new Fabricante("Samsung Electronics", "Korea", "");

                Operador tigo = new Operador("TIGO de Honduras", "Honduras");
                Operador claro = new Operador("CLARO", "Centroamerica");

                //Luego ya puede crear objetos de las clases dependientes
                Bateria bat1 = new Bateria(lg,6500);
                Bateria bat2 = new Bateria(samsung, 6000);
                Bateria bat3 = new Bateria(lg, 3500);
                Bateria bat4 = new Bateria(samsung, 5500);

                //Por Composicion la Marca en Bateria no se permite que sea null:
                //Bateria bat5 = new Bateria(null, 4000);

                Bateria bat5 = new Bateria(new Fabricante("ATL", "Hong Kong", ""), 4000);
                /*Observe que para bat5 en donde va el Fabricante no le pusimos
                 una variable de objeto sino que en este caso decidi crear
                el Fabricante de forma dinamica al crear la Bateria bat5.
                A este se le conoce como Objeto de un solo uso, se aconseja usar
                este tipo de objetos cuando Usted NO necesite REUTILIZAR el objeto
                en otras partes como sucedio con samsung y lg.*/

                Chip sim1 = new Chip(tigo, 99152959);
                Chip sim2 = new Chip(tigo, 99991599);
                Chip sim3 = new Chip(claro, 33133313);
                Chip sim4 = new Chip(claro, 88188889);
                Chip sim5 = new Chip(new Operador("AT&T", "USA"), 1300404035);
                /*tigo y claro se usan mas de una vez en los Chip; en cambio AT&T
                 solo se ocupo para crear sim5 por eso no le puse variable.*/

                SmartPhone cel1 = new SmartPhone(samsung, "S24", Enum.Capacidad.c512GB,
                    Enum.Capacidad.c8GB, bat2, sim1, null);
                cel1.Imprimir();
                //Observe que cel1 no tiene Chip2 (null)

                SmartPhone cel2 = new SmartPhone(lg, "Velvet", Enum.Capacidad.c256GB,
                    Enum.Capacidad.c6GB, bat5, sim4, sim2);
                cel2.Imprimir();

                SmartPhone cel3 = new SmartPhone(new Fabricante("Apple", "USA", "Tim Cook"),
                    "IPhone 18 Pro Max", Enum.Capacidad.c512GB,Enum.Capacidad.c16GB,bat4,sim4,null);
                cel3.Imprimir();

                /*Tambien se puede crear un Objeto Volatil, el cual se utiliza
                 en situaciones donde solo necesitamos ejecutar uno de sus Metodos
                para luego dejar de usarlo.*/
                new SmartPhone(samsung,"Galaxy Z Fold8",Enum.Capacidad.c512GB,
                    Enum.Capacidad.c8GB,bat1,sim5,sim1).Imprimir();
                //El objeto anterior Nace, luego ejecuta Imprimir() para
                //despues ser destruido por el Recolector de Basura (Garbace Collector)
                //Un objeto volatil NO es asignado a una variable para que
                //no consuma memoria RAM luego de haberlo utilizado.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
