using _04_CuentaAhorro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CuentaAhorro
{
    public class CuentaAhorro
    {
        //Propiedades
        public string NombreCliente {  get; set; }
        public string NumeroCuenta { get; set; }
        public float Saldo { get; private set; }
        public TipoCuenta Tipo {  get; set; }
        /*Note que la propiedad Saldo si bien tiene su
         respectivo get para indicar que se puede leer,
        luego indica que tiene un private set, esto
        quiere decir que Saldo solo podra ser modificado
        desde Metodos que nosotros debemos programar
        por separado. Cuanto usao private set no es necesario
        hacer un campo privado para Saldo.*/

        //Constructores
        public CuentaAhorro(string nombreCliente, string numeroCuenta)
        {
            this.NombreCliente = nombreCliente;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = 0;
            //desde dentro de la propia clase Saldo si puede modificarse
            //con el igual; pero desde afuera no podra
            this.Tipo = TipoCuenta.Ahorro;
        }

        //Metodos
        public void Depositar(float monto)
        {
            if (monto < 0)
                throw new ArgumentException("Monto a depositar no puede ser negativo");
            else
                this.Saldo += monto; //sumar el monto a depositar al Saldo actual
        }
        public void Retirar(float monto)
        {
            if (monto < 0) throw new ArgumentException("Monto a retirar no puede ser negativo");
            if (monto > this.Saldo) throw new ArgumentException("Fondos insuficientes");
            this.Saldo -= monto; //si logro llegar aqui se resta el monto al Saldo

            /*Observe que en el metodo Retirar no utilice else en las condiciones
             para detectar monto negativo o que se quiere retirar mas dinero
            del disponible; esto es porque throw si se dispara termina con la ejecucion
            del metodo Retirar.
            En caso de no dispararse ningun throw entonces se logra hacer el retiro.
            A esta forma de programar un metodo se le conoce como patron
            de diseño Early Returns.*/
        }
    }
}
