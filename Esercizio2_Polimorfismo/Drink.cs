using System;

public class Drink : IMenu
{
	public string Name { get; set; }
	public double Price { get; set; }
    public EnumMenu typeOfMeal { get; } = EnumMenu.Drink;
    public Drink()
	{
	}

    public void PrintOnMenu()
    {
        Console.WriteLine($"Nome della bevanda: {Name}\nPrezzo: {Price}€");
    }
}
