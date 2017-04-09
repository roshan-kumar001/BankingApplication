using BankingApplication.Classes;
using BankingApplication.Enums;
using BankingApplication.Interfaces;

namespace BankingApplication.Factory
{
    public static class OutputFactory
    {
        public static IOutput GetInstance(OutputType type)
        {
            IOutput output = null;
            switch (type)
            {
                case OutputType.Console:
                    output = new OutputOnConsole();
                    break;
                case OutputType.File:
                    output = new OutputOnFile();
                    break;
                case OutputType.Printer:
                    output = new OutputOnPrinter();
                    break;
            }

            return output;
        }
    }
}
