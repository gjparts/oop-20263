using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class Audio : Media
    {
        //Propiedades
        public string Artist {  get; set; }
        public string Album { get; set; }
        public int Year { get; set; }
        public int Track {  get; set; }
        
        //Constructor
        public Audio(string name, int size, string type, string extension, DateTime creationDate,
            Author author, int duration, string artist, string album, int year, int track)
            : base(name, size, type, extension, creationDate,author,duration)
        {
            this.Artist = artist;
            this.Album = album;
            this.Year = year;
            this.Track = track;
        }
    }
}
