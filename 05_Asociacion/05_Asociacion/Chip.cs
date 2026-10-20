using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Asociacion
{
    public class Chip
    {
        //Campos privados
        private Operador _proveedor;

        //Propiedades
        public Operador Proveedor
        {
            get => this._proveedor;
            set
            {
                //Asociacion entre Chip y Operador es por Composicion
                if (value == null)
                    throw new ArgumentNullException("Proveedor en Chip no puede ser null");
                else
                    this._proveedor = value; //se acepta
            }
        }
        public int NumeroTelefonico { get; set; }

        //Constructor
        public Chip(Operador proveedor, int numeroTelefonico)
        {
            this.Proveedor = proveedor;
            this.NumeroTelefonico = numeroTelefonico;
        }
    }
}
