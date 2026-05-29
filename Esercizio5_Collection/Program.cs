namespace Esercizio5_Collection
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
            // ESERCIZIO 5: Scrivere un programma che dichiari una mappa con chiave di tipo string e oggetto a vostra discrezione.
            // Il programma deve prendere in input dei valori, creare un oggetto e aggiungerlo alla mappa.
            // Dopo, provare a rimuovere l’oggetto e cercarlo nuovamente nella mappa.

            Dictionary<string, Person> peopleDictionary = new Dictionary<string, Person>();
            int cycleNumber = 0; //Variabile per tenere traccia del numero di cicli e applicare la logica di continuazione solo dopo il primo ciclo.
            bool cycleContinue = true; //Booleano per innescare il do...while successivo e, nel caso, terminarlo

            Console.WriteLine("CREAZIONE PERSONAGGI!");
            do
            {
                if (cycleNumber > 0)
                {
                    Console.Write("Vuoi continuare ad aggiungere personaggi? (si/no) ");
                    string cycleContinueString = (Console.ReadLine() ?? "").Trim().ToLower();

                    while (cycleContinueString != "si" && cycleContinueString != "no")
                    {
                        Console.Write("Per favore, inserisci 'si' o 'no': ");
                        cycleContinueString = (Console.ReadLine() ?? "").Trim().ToLower();
                    }

                    if(cycleContinueString == "no")
                    {
                        cycleContinue = false;
                        Console.WriteLine("FINE DELLA CREAZIONE PERSONAGGI");
                        continue; // Essendo un do...while con la condizione che si cambia a false, questo continue serve a saltare il resto del codice e uscire dal ciclo
                    }
                }


                Console.Write("Inserisci il nome: ");
                string characterName = Console.ReadLine() ?? "";
                Console.Write("Inserisci il cognome: ");
                string characterSurname = Console.ReadLine() ?? "";
                Console.Write("Inserisci l'età: ");
                string characterAgeString = Console.ReadLine() ?? "";

                int characterAge;
                while (!int.TryParse(characterAgeString, out characterAge) || characterAge <= 0 || characterAge > 120)
                {
                    Console.Write("Inserisci un'età valida: ");
                    characterAgeString = Console.ReadLine() ?? "";
                }

                while (peopleDictionary.ContainsKey(characterName)) // Visto che le chiavi sono uniche, controllo prima non ci sia un personaggio con lo stesso nome
                {
                    Console.Write("Nome già presente come chiave. Inserisci un altro nome: ");
                    characterName = Console.ReadLine() ?? "";
                }

                peopleDictionary.Add(characterName, new Person(characterName, characterSurname, characterAge));

                cycleNumber++;

            } while (cycleContinue);

            foreach(var item in peopleDictionary) // Prima stampo a schermo il dizionariom per mostrare all'utente i personaggi presenti prima della rimozione
            {
                Console.WriteLine($"Chiave: {item.Key}, Valori: Nome = {item.Value.Name} | Cognome = {item.Value.Surname} | Età = {item.Value.Age}");
            }

            Console.Write("Quale personaggio vuoi rimuovere? ");
            string characterToRemove = Console.ReadLine() ?? "";
            // Rimuovo il personaggio selezionato, ma prima controllo che esista, altrimenti chiedo all'utente di inserire un nome presente nella mappa
            while (!peopleDictionary.ContainsKey(characterToRemove))
            {
                Console.Write("Il personaggio non esiste. Inserisci un nome presente: ");
                characterToRemove = Console.ReadLine() ?? "";
            }

            peopleDictionary.Remove(characterToRemove);

            Console.WriteLine("ORA LA PROVA DEL NOVE PER CAPIRE SE DAVVERO IL PERSONAGGIO NON C'È PIÙ");
            // Prova richiesta dall'esercizio per verificare effettivamente che la rimozione sia andata a buon fine
            if(peopleDictionary.ContainsKey(characterToRemove))
            {
                Console.WriteLine("Qualcosa sarà andato storo...il personaggio è ancora presente nella mappa.");
            }
            else
            {
                Console.WriteLine("Visto! Il personaggio è stato rimosso con successo.");
            }

            Console.ReadLine(); // Usato per il debug, per mantenere la console aperta
        }
    }
}
