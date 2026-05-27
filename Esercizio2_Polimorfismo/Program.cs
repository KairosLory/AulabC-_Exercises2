namespace Esercizio2_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2- Esercizio del ristorante:

                Creare una classe Restaurant che contenga:

                attributi
                name
                dishes → Array di oggetti di classe Dish
                drinks → Array di oggetti di classe Drink

                metodi
                stampamenu → Ciclare prima i piatti stampando nome e prezzo, poi ripetere la stessa cosa con i drink


                Creare una classe Dish  che contenga: 

                attributi
                nome
                prezzo
                ( opzionale ) ingredienti

                metodi
                getter e setter


                Creare una classe Drink  che contenga: 

                attributi
                nome
                prezzo

                metodi
                getter e setter
             
             */

            // Creo un "Restaurant" per fare una prova che tutto funzioni come deve

            Console.OutputEncoding = System.Text.Encoding.UTF8; // Per forzare l'utilizzo del simbolo dell'euro.

            Restaurant lorenzoRestaurant = new Restaurant()
            {
                Name = "Ristorante di Lorenzo",
                Menu = new List<IMenu>() 
                {
                    new Dish()
                    {
                        Name = "Cotoletta alla milanese",
                        Price = 12.50d,
                        Ingredients = new List<string>()
                        {
                            "uova",
                            "carne di maiale",
                            "pangrattuggiato"
                        }
                    },
                    new Drink()
                    {
                        Name = "Coca-Cola",
                        Price = 3.50d,
                    },
                    new Dish()
                    {
                        Name = "Spaghetti alla carbonara",
                        Price = 11.00d,
                        Ingredients = new List<string>()
                        {
                            "spaghetti",
                            "uova",
                            "parmigiano",
                            "guanciale"
                        }
                    },
                    new Drink()
                    {
                        Name = "Fanta",
                        Price = 3.00d
                    },
                    new Drink()
                    {
                        Name = "Chinotto della Lurisia",
                        Price = 4.00d
                    },
                    new Dish()
                    {
                        Name = "Torta incredibile alla panna montata",
                        Price = 8.30d,
                        Ingredients = new List<string>()
                        {
                            "panna montata",
                            "pasta sfoglia",
                            "zucchero a velo",
                            "uova"
                        }
                    }
                }
            };

            lorenzoRestaurant.StampaMenu();

            Console.ReadLine(); 
        }
    }
}
