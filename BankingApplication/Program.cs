using BankingApplication.Client;

namespace BankingApplication
{
    class Program
    {
        // Client code
        static void Main(string[] args)
        {
            BankApp bankApp = new BankApp();
            bankApp.StartApp();
        }
    }
}
