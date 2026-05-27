using System;

public class Dish : IMenu
{
	public string Name { get; set; }
	public double Price { get; set; }
	public List<string> Ingredients { get; set; }

	public EnumMenu typeOfMeal { get; } = EnumMenu.Dish;

	public Dish()
	{
	}

    public void PrintOnMenu()
    {
        Console.WriteLine($"Nome del piatto: {Name}\nPrezzo: {Price}€\nLista degli Ingredienti:\n{string.Join('\n', Ingredients)}");
        
    }
}
