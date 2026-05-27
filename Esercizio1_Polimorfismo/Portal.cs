using System;

public static class Portal
{
	public static Type StartPortal()
	{
        Console.WriteLine("Benevenuto nel portale digitale dell'Università di Lorenzo!");
        Console.Write("Con che tipo di ruolo vuoi loggarti? (studente/professore)");

        string inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();

        while(inputRoleString != "studente" &&  inputRoleString != "professore")
        {
            Console.WriteLine("Mi dispiace ma hai inserito un ruolo non valido o non presente!");
            Console.Write("Reinserisci il ruolo: ");
            inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();
        }

        Type typeReturnStartPortal = inputRoleString switch
        {
            "studente" => typeof(Student),
            "professore" => typeof(Professor),
            _ => throw new Exception("Qualcoa è andato storto...")
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
        Console.Write("Nome: ");
        string studentName = (Console.ReadLine() ?? "");
        Console.Write("Cognome: ");
        string studentSurname = (Console.ReadLine() ?? "");
        Console.Write("Città di nascita: ");
        string studentCountryOfBirth = (Console.ReadLine() ?? "");
        Console.Write("Data di nascita: ");
        string studentDateOfBirthdayString = (Console.ReadLine() ?? "");
        DateOnly studentDateOfBirthday;

        while (!DateOnly.TryParse(studentDateOfBirthdayString, out studentDateOfBirthday))
        {
            Console.Write("Data non valida, prova a reinserirla: ");
            studentDateOfBirthdayString = (Console.ReadLine() ?? "");
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
        Console.WriteLine("Benvenuto professore!");

        Console.WriteLine("Inserisci ora i tuoi dati!");
        Console.Write("Nome: ");
        string professorName = (Console.ReadLine() ?? "");
        Console.Write("Cognome: ");
        string professorSurname = (Console.ReadLine() ?? "");
        Console.Write("Città di nascita: ");
        string professorCountryOfBirth = (Console.ReadLine() ?? "");
        Console.Write("Data di nascita: ");
        string professorDateOfBithdayString = (Console.ReadLine() ?? "");
        DateOnly professorDateOfBirthday;

        while (!DateOnly.TryParse(professorDateOfBithdayString, out professorDateOfBirthday))
        {
            Console.Write("Data non valida, prova a reinserirla: ");
            professorDateOfBithdayString = (Console.ReadLine() ?? "");
        }

        Professor professor  = new Professor()
        {
            Name = professorName,
            Surname = professorSurname,
            CountryOfBirth = professorCountryOfBirth,
            DateOfBithday = professorDateOfBirthday
        };

        PortalDisplayPersonalInfo(professor);
    }

    public static void PortalDisplayPersonalInfo(Person person)
    {
        person.DisplayPersonInfo();
    }

}
