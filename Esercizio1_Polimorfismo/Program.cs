namespace Esercizio1_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ESERCIZIO: Ho espanso la classe "Person" implementando due classi figlie "Professor" e "Student". Dopodichè ho creato una classe "Portal" per mimare una piccola interfaccia digitale di accesso ad un'università.

            UserRole typeStartPortal = Portal.StartPortal();
            Portal.ChoosePortal(typeStartPortal);
            
            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
