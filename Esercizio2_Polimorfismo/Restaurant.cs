using System;

public interface IMenu
{
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
			if (item is Drink)
			{
				continue;
			}
			item.PrintOnMenu();
		}
        foreach (var item in this.Menu)
        {
            if (item is Dish)
            {
                continue;
            }
            item.PrintOnMenu();
        }
    }
}
