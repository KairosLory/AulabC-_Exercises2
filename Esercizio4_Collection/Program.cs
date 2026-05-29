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

            foreach (var item in people) // Stampo la lista prima di modificare per mostrare in console le modifiche effettuate
            {
                Console.WriteLine($"Nome: {item.Name}, Cognome: {item.Surname}, Età: {item.Age}, Ha cani: {item.HasDog}");
            }
            // Chiedo all'utente quale persona vuole modificare, mostrando il numero corrispondente a ciascuna persona.
            // Ho gestito l'indice in maniera che per l'utente sia una scelta fra 1 e 5 e non fra 0 e 4, in modo da essere più intuitivo. Per gestire questa differenza, quando accedo alla lista, sottraggo 1 all'indice scelto dall'utente.
            Console.Write($"\nIn totale nella lista ci sono {people.Count} persone. Inserisci un numero da 1 a 5 per scegliere quale modificare: ");
            string inputIndexPlusOneString = (Console.ReadLine() ?? "").Trim();
            int inputIndexPlusOne;
            // while di controllo per assicurarsi che l'input sia un numero valido e che corrisponda a un indice esistente nella lista (1-5)
            while (!int.TryParse(inputIndexPlusOneString, out inputIndexPlusOne) || inputIndexPlusOne < 1 || inputIndexPlusOne > people.Count)
            {
                Console.Write($"Input non valido. Inserisci un numero da 1 a {people.Count} per scegliere quale persona modificare: ");
                inputIndexPlusOneString = (Console.ReadLine() ?? "").Trim();
            }
            // Una volta ottenuto un input valido, mostro all'utente quale persona ha selezionato e chiedo quale aspetto vuole modificare
            Console.WriteLine($"Hai selezionato la persona numbero {inputIndexPlusOne}, ovvero {people[inputIndexPlusOne - 1].Name}");
            Console.WriteLine($"Quale aspetto vuoi modificare di {people[inputIndexPlusOne - 1].Name}?" + 
                               "\n1. Il nome\n2. Il cognome\n3. L'età\n4. Se ha o meno dei cani");
            Console.Write("Inserisci numero: ");

            string inputNumberChoiceString = (Console.ReadLine() ?? "").Trim();
            int inputNumberChoice;
            while (!int.TryParse(inputNumberChoiceString, out inputNumberChoice) || inputNumberChoice < 1 || inputNumberChoice > 4)
            {
                Console.WriteLine($"Input non valido. Inserisci un numero da 1 a 4 per scegliere l'aspetto da modificare: ");
                inputNumberChoiceString = (Console.ReadLine() ?? "").Trim();
            }
            // switch che gestisce le diverse modifiche della lista in base al numero scelto in precedenza. Il caso di 'default' non è necessario in quanto i while precedenti, unito all'operatore ??, gestiscono ogni eccezione possibile
            switch(inputNumberChoice)
            {
                case 1:
                    Console.WriteLine($"Inserisci il nuovo nome per {people[inputIndexPlusOne - 1].Name}: ");
                    people[inputIndexPlusOne - 1].Name = Console.ReadLine() ?? "";
                    break;
                case 2:
                    Console.WriteLine($"Inserisci il nuovo cognome per {people[inputIndexPlusOne - 1].Name}: ");
                    people[inputIndexPlusOne - 1].Surname = Console.ReadLine() ?? "";
                    break;
                case 3:
                    Console.WriteLine($"Inserisci la nuova età per {people[inputIndexPlusOne - 1].Name}: ");
                    string newAgeString = Console.ReadLine() ?? "";
                    int newAge;
                    while (!int.TryParse(newAgeString, out newAge) || newAge < 0)
                    {
                        Console.WriteLine($"Input non valido. Inserisci un numero positivo per l'età: ");
                        newAgeString = Console.ReadLine() ?? "";
                    }
                    people[inputIndexPlusOne - 1].Age = newAge;
                    break;
                case 4:
                    Console.WriteLine($"Inserisci 'true' se {people[inputIndexPlusOne - 1].Name} ha dei cani, altrimenti 'false': ");
                    string hasDogString = Console.ReadLine() ?? "";
                    bool hasDog;
                    while (!bool.TryParse(hasDogString, out hasDog))
                    {
                        Console.WriteLine($"Input non valido. Inserisci 'true' o 'false': ");
                        hasDogString = Console.ReadLine() ?? "";
                    }
                    people[inputIndexPlusOne - 1].HasDog = hasDog;
                    break;
            }

            foreach(var item in people) // Stampo a console la lista dopo le modifiche
            {
                Console.WriteLine($"Nome: {item.Name}, Cognome: {item.Surname}, Età: {item.Age}, Ha cani: {item.HasDog}");
            }

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
