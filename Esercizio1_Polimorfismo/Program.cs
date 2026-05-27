namespace Esercizio1_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserRole typeStartPortal = Portal.StartPortal();
            Portal.ChoosePortal(typeStartPortal);
            

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
