using System;

public enum UserRole // Enum che serve a dividere i processi dentro Portal, senza usare la classe "Type"
{
    Student,
    Professor
}

public static class Portal // Classe che gestisce il portale online dell'università
{
	public static UserRole StartPortal() // Inizio del portale dove l'utente deve decidere con quale ruolo loggarsi
	{
        Console.WriteLine("Benevenuto nel portale digitale dell'Università di Lorenzo!");
        Console.Write("Con che tipo di ruolo vuoi loggarti? (studente/professore)");

        string inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();

        while(inputRoleString != "studente" &&  inputRoleString != "professore") // Ciclo per gestire casi contrari all'inserimento del ruolo
        {
            Console.WriteLine("Mi dispiace ma hai inserito un ruolo non valido o non presente!");
            Console.Write("Reinserisci il ruolo: ");
            inputRoleString = (Console.ReadLine() ?? "Spiacente, ma è una null string").Trim().ToLower();
        }

        UserRole typeReturnStartPortal = inputRoleString switch // Switch per assegnare l'Enum corrispondente al ruolo
        {
            "studente" => UserRole.Student,
            "professore" => UserRole.Professor,
            _ => throw new Exception("Qualcoa è andato storto...")
        };

        return typeReturnStartPortal;
    }

    public static void ChoosePortal(UserRole typeOfPerson) // Metodo che dirige l'azione del portale a seconda del tipo di ruolo dell'utente
    {
        if (typeOfPerson == UserRole.Student)
        {
            ShowMenuStudent();
        }
        else
        {
            ShowMenuProfessor();
        }
    }

    public static void ShowMenuStudent() // Metodo che gestisce l'interfaccia dal punto di vista dello studente
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
    public static void ShowMenuProfessor() // Metodo che gestisce l'interfaccia dal punto di vista del professore
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

    public static void PortalDisplayPersonalInfo(Person person) // Metodo che sfrutta il polimorfismo per stampare correttamente a console senza badare al tipo specifico dell'oggetto
    {
        person.DisplayPersonInfo();
    }

}
