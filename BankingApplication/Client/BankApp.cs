using BankingApplication.Classes;
using BankingApplication.Enums;
using BankingApplication.Factory;
using BankingApplication.Interfaces;
using System;
using System.Collections.Generic;

namespace BankingApplication.Client
{
    public class BankApp
    {
        IOutput output;

        // Here, we can inject the OutputType using Dependency Inject. Constructor injection.
        public BankApp()
        {
            output = OutputFactory.GetInstance(OutputType.Console);
        }

        public void StartApp()
        {
            double depositAmount = 200;
            double withdrawalAmount = 20;
            string customerName = "Roshan Kumar Singh";

            // Getting the account based on Factory Pattern.
            BaseAccount account = AccountFactory.GetInstance(AccountType.Checkings);
            account.CustomerName = customerName;

            output.Print("Account details for: " + account.CustomerName);
            output.Print();

            // Deposit
            Deposit(account, depositAmount / 1);
            Deposit(account, depositAmount / 2);
            Deposit(account, depositAmount / 4);
            Deposit(account, depositAmount / 8);
            Deposit(account, depositAmount / 16);

            // Withdrawal
            Withdraw(account, withdrawalAmount);

            // Display transactions
            DisplayTransactions(account.GetTransactions());

            // Wait for input.
            Console.ReadLine();
        }

        private bool Deposit(BaseAccount account, double amount)
        {
            return account.Deposit(amount);
        }

        private bool Withdraw(BaseAccount account, double amount)
        {
            return account.Withdraw(amount);
        }

        private void DisplayTransactions(IEnumerable<Transaction> transactions)
        {
            output.Print("Posted Date \t Description \t\t\t\t Type \t\t Status \t Amount \t Balance");
            output.Print("------------------------------------------------------------------------------------------------------------------------");
            foreach (var transaction in transactions)
            {
                output.Print(transaction.PostedDate.ToShortDateString() + " \t " + transaction.Description + " \t\t\t\t " + transaction.Type + " \t " + transaction.Status + " \t " + transaction.Amount + " \t\t " + transaction.Balance);
            }
        }
    }
}
