using System;

public class Dish : IMenu
{
	public string Name { get; set; }
	public double Price { get; set; }
	public List<string> Ingredients { get; set; }


	public Dish()
	{
	}

    public void PrintOnMenu()
    {
        Console.WriteLine($"Nome del piatto: {Name}\nPrezzo: {Price}€\nLista degli Ingredienti: {string.Join('\n', Ingredients)}");
        
    }
}
