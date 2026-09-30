using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Clases
{
    public class Mascota
    {
        //Propiedades: caracteristica de la clase
        //get = se puede leer
        //set = se puede escribir
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public int Edad {  get; set; }
        public char Genero { get; set; }
        /*A get y set se les conoce como modificadores de acceso,
         o descriptores de acceso.
        Cuando una propiedad es public quiere decir que se puede
        acceder a ella desde afuera de la clase.
        { get; set; } indica que la propiedad es de lectura/escritura
        { get; } indica que la propiedad solo es de lectura
        { set; } esto no es permitido
        Si no coloca nada es lo mismo como que dijera {get;set;}*/
    }
}
