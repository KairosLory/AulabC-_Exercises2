namespace Esercizio1_Collection
{
    internal class Videogame
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public Videogame(string title, string genre, int releaseYear)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
        }
        public Videogame()
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 1: Creare una List con N oggetti di una classe creata da voi.
            // Creare un’altra List vuota, ciclare la prima lista filtrando gli elementi in base a un criterio scelto da voi e inserire gli elementi nella seconda lista.


            List<Videogame> videogames = new List<Videogame>()
            {
                new Videogame("Clair Obscur", "RPG", 2025),
                new Videogame("The Last of Us", "Action-Adventure", 2013),
                new Videogame("Cyberpunk 2077", "RPG", 2020)
            };

            // Uso LINQ per creare una nuova lista di solo giochi "RPG" e ordinati per anno di rilascio.
            List<Videogame> filteredList = videogames.Where(videogame => videogame.Genre == "RPG").OrderBy(videogame => videogame.ReleaseYear).ToList();

            foreach(var item in filteredList)
            {
                Console.WriteLine($"Titolo: {item.Title}, Genere: {item.Genre}, Anno di rilascio: {item.ReleaseYear}");
            }

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
