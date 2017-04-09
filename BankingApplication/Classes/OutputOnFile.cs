using BankingApplication.Interfaces;
using System;

namespace BankingApplication.Classes
{
    public class OutputOnFile : IOutput
    {
        public void Print(string message)
        {
            Console.WriteLine("ON FILE: {0}", message);
        }
    }
}
