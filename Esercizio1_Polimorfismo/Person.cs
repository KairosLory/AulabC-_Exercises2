using System;

public abstract class Person
{
	public string Name { get; init; }
	public string Surname { get; init; }
	public string CountryOfBirth{ get; init; }
	public DateOnly DateOfBithday { get; init; }

	public abstract void DisplayPersonInfo();
}
