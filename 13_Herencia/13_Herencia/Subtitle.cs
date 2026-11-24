using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class Subtitle
    {
        //Propiedades
        public string Language { get; set; }
        public Author Author { get; set; }

        //Constructor
        public Subtitle(string language, Author author)
        {
            this.Language = language;
            this.Author = author;
        }
    }
}
