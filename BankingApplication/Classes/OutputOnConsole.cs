using BankingApplication.Interfaces;
using System;

namespace BankingApplication.Classes
{
    class OutputOnConsole : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
