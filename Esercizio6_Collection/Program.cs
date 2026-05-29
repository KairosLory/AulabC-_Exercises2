namespace Esercizio6_Collection
{
    internal class Program
    {
        static List<int> CreateIntList()
        {
            List<int> numbers = new List<int>();

            bool continueAdding = true;

            while (true)
            {
                Console.Write("Inserisci un numero o 'stop' per fermare l'inserimento: ");
                string input = (Console.ReadLine() ?? "").Trim().ToLower();

                if (input == "stop")
                    break;

                if (int.TryParse(input, out int inputNumber))
                {
                    numbers.Add(inputNumber);
                }
                else
                {
                    Console.WriteLine("Input non valido. Inserisci un numero o 'stop'.");
                }
            }

            return numbers;
        }
        static void Main(string[] args)
        {
            // ESERCIZIO 6: Scrivere un programma che crei una lista di elementi e che ne rimuova i duplicati.

            List<int> numbersList = CreateIntList();

            foreach (int number in numbersList)
            {
                Console.Write(number + " ");
            }

            var numbersListDistinct = numbersList.Distinct().ToList(); //Uso LINQ per rimuovere i duplicati e poi trasformo subito il risultato in una lista
            Console.WriteLine("\nOra mostro la lista senza alcuna ripetizione di numeri!");
            foreach (int number in numbersListDistinct)
            {
                Console.Write(number + " ");
            }


            Console.ReadLine(); // Per mantenere la console aperta dopo l'esecuzione
        }
    }
}
