namespace Esercizio1_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type typeStartPortal = Portal.StartPortal();
            Portal.ChoosePortal(typeStartPortal);
            

            Console.ReadLine(); // Utilizzo per il debug
        }
    }
}
