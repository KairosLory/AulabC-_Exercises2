using System;

public abstract class Person
{
	public string Name { get; init; }
	public string Surname { get; init; }
	public string CountryOfBirth{ get; init; }
	public DateOnly DateOfBithday { get; init; }

	public abstract void DisplayPersonInfo(); // Sfruttamento della classe abstract per creare un display diverso a seconda del tipo ddi oggetto, senza esplicitarlo manualmente
}
