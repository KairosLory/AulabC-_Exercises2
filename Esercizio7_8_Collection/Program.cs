namespace Esercizio7_8_Collection
{
    public interface IItem
    {
        string Name { get; set; }
        int Price { get; set; }
    }

    internal class Weapon : IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Weapon(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    internal class Potion : IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Potion(string name, int price)
        {
            Name = name;
            Price = price;
        }
    } 

    internal class Armor : IItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Armor(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    internal class Inventory<T> where T : IItem // Metto il vicolo in maniera tale che si accettino solo coloro che implementano l'interfaccia ITem
    {
        public List<T> Items { get; set; }
        public Inventory()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            Items.Add(item);
        }
        public void DisplayItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine($"Nome: {item.Name}, Prezzo: {item.Price}");
            }
        }
    }
    internal class Program
    {
        static void DisplayItem<T>(T item) where T : IItem
        {
            Console.WriteLine($"Nome: {item.Name}, Prezzo: {item.Price}");
        }
        static void Main(string[] args)
        {
            // ESERCIZIO 7: Scrivere una classe generica che possa accettare qualsiasi tipo di dato.
            // ESERCIZIO 8: Scrivere un metodo generico.

            IItem firstSpada = new Weapon("Spada", 100);
            IItem firstArmor = new Armor("Armatura di Ferro", 250);
            IItem secondSpada = new Weapon("Spadone dell'Amicizia", 10000);
            IItem secondArmor = new Armor("Armatura di Diamante", 500);
            // Prova del metodo generico
            DisplayItem(firstSpada);
            DisplayItem(firstArmor);
            // Prova classe generica con la classe Armor. Necessità del cast per poter aggiungere l'oggetto alla lista, in quanto è di tipo IItem e non Armor
            Inventory<Armor> inventoryOnlyArmor = new Inventory<Armor>();
            inventoryOnlyArmor.AddItem((Armor)secondArmor);
            // Prova classe generica con l'interfaccia IItem. Non è necessario il cast, in quanto accetta qualsiasi oggetto che implementa l'interfaccia
            Inventory<IItem> inventoryGeneric = new Inventory<IItem>();
            inventoryGeneric.AddItem(firstSpada);
            inventoryGeneric.AddItem(firstArmor);

            Console.ReadLine(); // Per mantenere la console aperta dopo l'esecuzione
        }
    }
}
