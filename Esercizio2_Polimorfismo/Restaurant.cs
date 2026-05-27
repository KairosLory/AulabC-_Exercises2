using System;

public enum EnumMenu // Enum per avere dopo una divisione dell'azione e non utilizzare il "Type" di C#.
{
	Dish,
	Drink
}

public interface IMenu // Utilizzo dell'interfaccia in modo da utilizzare il polimorfismo nella stampa dei menu.
{
	public EnumMenu typeOfMeal { get; }
	public void PrintOnMenu();
}

public class Restaurant
{
	public string Name { get; init; }

    //public Dish[] Dishes { get; set; } Rimpiazzato dall'interfaccia IMenu
    //public Drink[] Drinks { get; set; } Rimpiazzato dall'interfaccia IMenu
    public List<IMenu> Menu { get; set; }
	public Restaurant()
	{
	}

	public void StampaMenu() // Ho usato due cicli per rispettare la consegna che voleva i "Drink" stampati dopo
	{
		foreach(var item in this.Menu)
		{
			if (item.typeOfMeal == EnumMenu.Drink)
			{
				continue;
			}
			item.PrintOnMenu();
		}
        foreach (var item in this.Menu)
        {
            if (item.typeOfMeal == EnumMenu.Dish)
            {
                continue;
            }
            item.PrintOnMenu();
        }
    }
}
