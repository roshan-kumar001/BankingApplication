using BankingApplication.Classes;
using BankingApplication.Enums;
using BankingApplication.Factory;
using System;
using System.Collections.Generic;

namespace BankingApplication.Client
{
    public class BankApp
    {
        public void StartApp()
        {
            double depositAmount = 200;
            double withdrawalAmount = 20;
            string customerName = "Roshan Kumar Singh";

            // Getting the account based on Factory Pattern.
            BaseAccount account = AccountFactory.GetAccount(AccountType.Checkings);
            account.CustomerName = customerName;

            // Initialize
            account.Initialize();

            Console.WriteLine("Account details for: " + customerName);
            Console.WriteLine();

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
            Console.WriteLine("Posted Date \t Description \t\t\t\t Type \t\t Status \t Amount \t Balance");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction.PostedDate.ToShortDateString() + " \t " + transaction.Description + " \t\t\t\t " + transaction.Type + " \t " + transaction.Status + " \t " + transaction.Amount + " \t\t " + transaction.Balance);
            }
        }
    }
}
