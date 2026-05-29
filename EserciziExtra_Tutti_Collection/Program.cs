namespace EserciziExtra_Tutti_Collection
{
    public interface IShop<T>
    {
        string Name { get; set; }
        int Price { get; set; }
        bool HasMoreThanOne { get; set; }
    }

    internal class Armor : IShop<Armor>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool HasMoreThanOne { get; set; }
        public Armor(string name, int price, bool hasMoreThanOne)
        {
            Name = name;
            Price = price;
            HasMoreThanOne = hasMoreThanOne;
        }
    }
    internal class Magic : IShop<Magic>
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool HasMoreThanOne { get; set; }
        public Magic(string name, int price, bool hasMoreThanOne)
        {
            Name = name;
            Price = price;
            HasMoreThanOne = hasMoreThanOne;
        }
    }
    internal class Program
    {
        static T GetMax<T>(T firstValue , T secondValue) where T: IComparable<T>
        {
            return firstValue.CompareTo(secondValue) >= 0 ? firstValue : secondValue; // Utilizzo il metodo CompareTo per confrontare i due valori e restituire il massimo. Nel caso in cui i valori siano uguali, restituisco il primo valore.
        }
        static void Main(string[] args)
        {
            /* 
             * ESERCIZIO EXTRA 1: Creare un’interfaccia generica.
             * ESERCIZIO EXTRA 2: Creare una LinkedList, aggiungere e rimuovere elementi da inizio e fine.
             * ESERCIZIO EXTRA 3: Creare un Dictionary con chiave stringa e valore oggetto complesso, poi stampare chiavi e valori separatamente.
             * ESERCIZIO EXTRA 4: Scrivere un metodo generico con vincolo che restituisca il massimo tra due valori.
             */

            Magic fireMagic = new Magic("Fire Magic", 100, true);
            Magic iceMagic = new Magic("Ice Magic", 120, true);
            Magic airMagic = new Magic("Air Magic", 120, true);
            Magic lightMagic = new Magic("Light Magic", 145, false);
            Armor steelArmor = new Armor("Steel Armor", 200, true);
            Armor bronzeArmor = new Armor("Bronze Armor", 150, false);

            LinkedList<Magic> linkedMagicList = new LinkedList<Magic>(new Magic[] { fireMagic, iceMagic, airMagic, lightMagic }); // Sfruttando uno dei costruttori di LinkedList<T>
            linkedMagicList.AddFirst(new Magic("Dark Magic", 130, true)); // Aggiungo un elemento all'inizio della LinkedList
            linkedMagicList.AddLast(new Magic("Earth Magic", 110, true)); // Aggiungo un elemento alla fine della LinkedList
            // Stampo la LinkedList dopo le aggiunte per verificare che gli elementi siano stati aggiunti correttamente
            foreach (Magic magic in linkedMagicList)
            {
                Console.WriteLine($"Nome della magia: {magic.Name}, Prezzo: {magic.Price}, Ne è presente più d'una? {magic.HasMoreThanOne}");
            }

            Console.WriteLine("\n"); // Riga per mostrare una separazione tra le stampe prima e dopo le rimozioni

            linkedMagicList.RemoveFirst(); // Rimuovo l'elemento all'inizio della LinkedList
            linkedMagicList.RemoveLast(); // Rimuovo l'elemento alla fine della LinkedList
            // Stampo nuovamente la LinkedList dopo le rimozioni per verificare che gli elementi siano stati rimossi correttamente
            foreach (Magic magic in linkedMagicList)
            {
                Console.WriteLine($"Nome della magia: {magic.Name}, Prezzo: {magic.Price}, Ne è presente più d'una? {magic.HasMoreThanOne}");
            }

            Console.WriteLine("\n"); // Riga vuota per dividere gli esericizi sulla console

            Dictionary<string, Armor> armorDictionary = new Dictionary<string, Armor>()
            {
                {"Prima Armatura", steelArmor },
                {"Seconda Armatura", bronzeArmor }
            };

            foreach(var item in armorDictionary.Keys) // Utilizzo la proprietà Keys del Dictionary per iterare solo sulle chiavi e stamparle
            {
                Console.WriteLine(item);
            }

            foreach(var item in armorDictionary.Values) // Utilizzo la proprietà Values del Dictionary per iterare solo sui valori e stamparli
            {
                Console.WriteLine($"Nome Armatura: {item.Name}, Prezzo Armatura: {item.Price}");
            }

            Console.WriteLine("\n"); // Riga vuota per dividere gli esericizi sulla console

            Console.WriteLine("Tra 5 e 10 il maggiore è: " + GetMax<int>(5, 10)); // Esempio di utilizzo del metodo generico GetMax con due interi
            Console.WriteLine("Tra 'Ciao' e 'Mondo' il maggiore è: " + GetMax<string>("Ciao", "Mondo")); // Esempio di utilizzo del metodo generico GetMax con due stringhe. Viene messo primo Mondo perché, secondo l'ordinamento lessicografico, viene dopo Ciao
            Console.WriteLine("Tra 3.14 e 2.71 il maggiore è: " + GetMax<double>(3.14, 2.71)); // Esempio di utilizzo del metodo generico GetMax con due double
            Console.WriteLine("Tra 'D' e 'A' il maggiore è: " +     GetMax<char>('D', 'A')); // Esempio di utilizzo del metodo generico GetMax con due char. Viene messo primo D perché, secondo l'ordinamento lessicografico, viene dopo A

            Console.ReadLine(); // Per evitare che la console si chiuda subito dopo l'esecuzione
        }
    }
}
