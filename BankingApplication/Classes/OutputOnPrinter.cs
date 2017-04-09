using BankingApplication.Interfaces;
using System;

namespace BankingApplication.Classes
{
    class OutputOnPrinter : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine("ON PRINTER: {0}", message);
        }
    }
}
