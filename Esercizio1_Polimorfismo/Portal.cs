using System;

public static class Portal
{
	public static Type StartPortal()
	{
        Console.WriteLine("Benevenuto nel portale digitale dell'Università di Lorenzo!");
        Console.WriteLine("Con che tipo di ruolo vuoi loggarti? (studente/professore)");

        string inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();

        while(inputRoleString != "studente" &&  inputRoleString != "professore")
        {
            Console.WriteLine("Mi dispiace ma hai inserito un ruolo non valido o non presente!");
            Console.WriteLine("Reinserisci il ruolo: ");
            inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();
        }

        Type typeReturnStartPortal = inputRoleString switch
        {
            "studente" => typeof(Student),
            "professore" => typeof(Professor)
        };

        return typeReturnStartPortal;
    }

    public static void ChoosePortal(Type typeOfPerson)
    {
        if (typeOfPerson == typeof(Student))
        {
            ShowMenuStudent();
        }
        else
        {
            ShowMenuProfessor();
        }
    }

    public static void ShowMenuStudent()
    {

        Console.WriteLine("Benvenuto studente!");

        Console.WriteLine("Inserisci ora i tuoi dati!");
        Console.WriteLine("Nome: ");
        string studentName = Console.ReadLine();
        Console.WriteLine("Cognome: ");
        string studentSurname = Console.ReadLine();
        Console.WriteLine("Città di nascita: ");
        string studentCountryOfBirth = Console.ReadLine();
        Console.WriteLine("Data di nascita: ");
        string studentDateOfBirthdayString = Console.ReadLine();
        DateTime studentDateOfBirthday;

        while (!DateTime.TryParse(studentDateOfBirthdayString, out studentDateOfBirthday))
        {
            Console.WriteLine("Data non valida, prova a reinserirla: ");
            studentDateOfBirthdayString = Console.ReadLine();
        }

        Student student = new Student()
        {
            Name = studentName,
            Surname = studentSurname,
            CountryOfBirth = studentCountryOfBirth,
            DateOfBithday = studentDateOfBirthday
        };

        PortalDisplayPersonalInfo(student);

    }
    public static void ShowMenuProfessor()
    {

    }

    public static void PortalDisplayPersonalInfo(Person person)
    {
        person.DisplayPersonInfo();
    }

}
