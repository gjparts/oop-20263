using _06_Asociacion.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Asociacion
{
    public class Cargo
    {
        //Campos privados
        private Empresa _empresa;
        private float _salario;

        //Propiedades
        public string Descripcion { get; set; }
        public JornadaLaboral Jornada { get; set; }
        public Empresa Empresa
        {
            get => this._empresa;
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Empresa en Cargo no puede ser null");
                else
                    this._empresa = value; //se acepta
            }
        }
        public float Salario
        {
            get => this._salario;
            set
            {
                if (value >= 0)
                    this._salario = value; //se acepta
                else
                    throw new ArgumentException("Salario debe ser un valor >= 0");
            }
        }

        //Constructor
        public Cargo(string descripcion, JornadaLaboral jornada, Empresa empresa, float salario)
        {
            this.Descripcion = descripcion;
            this.Jornada = jornada;
            this.Empresa = empresa;
            this.Salario = salario;
        }
    }
}
