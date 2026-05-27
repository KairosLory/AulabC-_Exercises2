using System;

public class Student : Person
{
	public Student()
	{
	}

    public override void DisplayPersonInfo()
    {
        Console.WriteLine("SCHEDA DELLO STUDENTE");
        Console.WriteLine($"Ciao, mi chiamo {Name} {Surname} e sono nato il {DateOfBithday} a {CountryOfBirth}");
        Console.WriteLine($"La mia email universitaria è {Name.ToLower()}.{Surname.ToLower()}@edu.unilorenzo.it");
    }
}
