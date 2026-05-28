namespace Esercizio3_Collection
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Person()
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 3: Creare una mappa (Dictionary / Map) con oggetti.
            // Chiedere all’utente di inserire una chiave e provare a cercare l’oggetto corrispondente nella mappa.

            Dictionary<string, Person> dictionaryPlacePerson = new Dictionary<string, Person>();

            dictionaryPlacePerson.Add("Primo", new Person("Mario", "Rossi", 30));
            dictionaryPlacePerson.Add("Secondo", new Person("Luigi", "Verdi", 20));
            dictionaryPlacePerson.Add("Terzo", new Person("Gianni", "Viola", 34));
            dictionaryPlacePerson.Add("Quarto", new Person("Sebastian", "Lilla", 43));

            Console.WriteLine("Inserisci che posizione vuoi vedere: ");
            string position = (Console.ReadLine() ?? "").Trim();

            while (!dictionaryPlacePerson.ContainsKey(position)) // Controllo se la chiave esiste, se non esiste chiedo di inserirla nuovamente
            {
                Console.WriteLine("Mi dispiace, sono pigro...ho inserito solo le prime quattro posizioni. Inoltre ho lasciato la prima lettera maiuscola.\nRiprova: ");
                position = (Console.ReadLine() ?? "").Trim();
            }

            Person person = dictionaryPlacePerson[position]; // Recupero l'oggetto corrispondente alla chiave inserita
            Console.WriteLine($"In posizione {position} vi è {person.Name} {person.Surname}, {person.Age} anni.");

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
