namespace Esercizio2_Collection
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

        public override bool Equals(object? obj) // Sovrascrive il metodo Equals per confrontare due oggetti Videogame
        {
            if(obj is not Videogame other)
            {
                return false;
            }
            
            return Title == other.Title && Genre == other.Genre && ReleaseYear == other.ReleaseYear;
        }

        public override int GetHashCode() // Sovrascrive il metodo GetHashCode per generare un hash code basato sui campi della classe
        {
            return HashCode.Combine(Title, Genre, ReleaseYear);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 2: Creare un HashSet che contenga oggetti di una classe creata da voi e che non ammetta ripetizioni, sovrascrivendo Equals() e GetHashCode().

            HashSet<Videogame> videogamesSet = new HashSet<Videogame>();

            videogamesSet.Add(new Videogame("The Legend of Zelda: Breath of the Wild", "Action-Adventure", 2017));
            videogamesSet.Add(new Videogame("The Legend of Zelda: Breath of the Wild", "Action-Adventure", 2023));
            videogamesSet.Add(new Videogame("The Legend of Zelda: Breath of the Wild", "Action-Adventure", 2017)); // Duplicato, non verrà aggiunto
            videogamesSet.Add(new Videogame("Clair Obscur", "RPG", 2025));

            foreach(var item in videogamesSet)
            {
                Console.WriteLine($"Title: {item.Title}, Genre: {item.Genre}, Release Year: {item.ReleaseYear}");
            }

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
