namespace _13_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Gerardo Portillo", "gerardoportillo.com", "");
            Author a2 = new Author("David Wise", "", "");

            Document doc1 = new Document("Informe", 386569, "Microsoft Word Document", "docx",
                DateTime.Now,a1,DateTime.Now,295);
            doc1.Print();

            Audio sound1 = new Audio("Stickerbrush Symphony", 10525645, "MP3 File", "mp3",
                new DateTime(2025, 8, 2), a2, 263, "David Wise", "Donkey Kong Country 2",
                1996, 17);
            sound1.Print();

            String[] pistas = {"English","Español Latinoamerica"};
            List<Subtitle> coleccion = new List<Subtitle>();
            coleccion.Add(new Subtitle("English", null));
            coleccion.Add(new Subtitle("Español", new Author("GNula", "", "")));
            coleccion.Add(new Subtitle("Chino",null));

            Video movie1 = new Video("Lord of the Rings: The Two Towers", 549755810,
                "Matroska Video File", "mkv", DateTime.Now, null, 5400, "h264", 20, pistas,
                coleccion);
            movie1.Print();
        }
    }
}
