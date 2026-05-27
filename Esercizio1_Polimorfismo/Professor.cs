using System;

public class Professor : Person
{
	public Professor()
	{
	}

    public override void DisplayPersonInfo()
    {
        Console.WriteLine("SCHEDA DEL PROFESSORE");
        Console.WriteLine($"Ciao, mi chiamo {Name} {Surname} e sono nato il {DateOfBithday} a {CountryOfBirth}");
        Console.WriteLine($"La mia email universitaria è {Name.ToLower()}.{Surname.ToLower()}@unilorenzo.it");
    }
}
