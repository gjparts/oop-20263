using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class File
    {
        //Propiedades
        public string Name { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
        public string Extension { get; set; }
        public DateTime CreationDate { get; set; }

        //Constructor
        public File(string name, int size, string type, string extension, DateTime creationDate)
        {
            this.Name = name;
            this.Size = size;
            this.Type = type;
            this.Extension = extension;
            this.CreationDate = creationDate;
        }

        //Metodos
        public void Print()
        {
            Console.WriteLine("------------------- FILE -------------------");
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Size in bytes: {this.Size}");
            Console.WriteLine($"Type: {this.Type}");
            Console.WriteLine($"Extension: {this.Extension}");
            Console.WriteLine($"Creation Date: {this.CreationDate}");
        }
    }
}
