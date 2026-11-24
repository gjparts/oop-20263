using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Herencia
{
    public class Video : Media
    {
        //Propiedades
        public string Codec {  get; set; }
        public int Chapters { get; set; }
        public string[] Audio {  get; set; }
        public List<Subtitle> Subtitles { get; set; }

        //Constructor
        public Video(string name, int size, string type, string extension, DateTime creationDate,
            Author author, int duration, string codec, int chapters, string[] audio,
            List<Subtitle> subtitles)
            :base(name, size, type, extension, creationDate, author, duration)
        {
            this.Codec = codec;
            this.Chapters = chapters;
            this.Audio = audio;
            this.Subtitles = subtitles;
        }
    }
}
