namespace Esercizio4_Collection
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool HasDog { get; set; }

        public Person(string name, string surname, int age, bool hasDog)
        {
            Name = name;
            Surname = surname;
            Age = age;
            HasDog = hasDog;
        }

        public Person()
        {
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO 4: Scrivere un programma per aggiornare un elemento specifico di una lista in base al suo indice.
            // Creare una lista di persone, chiedere all’utente quale persona vuole modificare, chiedere i nuovi dati e aggiornare quell’elemento.

            List<Person> people = new List<Person>()
            { 
                new Person("Mario", "Rossi", 30, true),
                new Person("Luigi", "Verdi", 20, false),
                new Person("Giulia", "Bianchi", 25, true),
                new Person("Anna", "Neri", 28, false),
                new Person("Paolo", "Gialli", 35, true)
            };

            Console.WriteLine($"In totale nella lista ci sono {people.Count} persone. Inserisci un numero da 1 a 5 per scegliere quale modificare: ");
            string inputIndexPlusOneString = (Console.ReadLine() ?? "").Trim();
            int inputIndexPlusOne;

            while (!int.TryParse(inputIndexPlusOneString, out inputIndexPlusOne) || inputIndexPlusOne < 1 || inputIndexPlusOne > people.Count)
            {
                Console.WriteLine($"Input non valido. Inserisci un numero da 1 a {people.Count} per scegliere quale persona modificare: ");
                inputIndexPlusOneString = (Console.ReadLine() ?? "").Trim();
            }

            Console.WriteLine($"Hai selezionato la persona numbero {inputIndexPlusOne}, ovvero {people[inputIndexPlusOne - 1].Name}");
            Console.WriteLine($"Quale aspetto vuoi modificare di {people[inputIndexPlusOne - 1].Name}?" + 
                               "\n1. Il nome\n2. Il cognome\n3. L'età\n4. Se ha o meno dei cani");

            string inputNumberChoiceString = (Console.ReadLine() ?? "").Trim();
            while (!int.TryParse(inputIndexPlusOneString, out inputIndexPlusOne) || inputIndexPlusOne < 1 || inputIndexPlusOne > 4)
            {
                Console.WriteLine($"Input non valido. Inserisci un numero da 1 a 4 per scegliere l'aspetto da modificare: ");
                inputIndexPlusOneString = (Console.ReadLine() ?? "").Trim();
            }



            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
