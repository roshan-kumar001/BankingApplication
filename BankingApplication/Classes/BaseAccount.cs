using BankingApplication.Enums;
using System;
using System.Collections.Generic;

namespace BankingApplication.Classes
{
    public abstract class BaseAccount
    {
        private List<Transaction> transactions;
        public string CustomerName { get; set; }
        protected double Balance { get; set; }

        public BaseAccount()
        {
            transactions = new List<Transaction>();
            Initialize();
        }

        public virtual void Initialize()
        {
        }

        public abstract bool Withdraw(double amount);

        public virtual bool Deposit(double amount)
        {
            Balance += amount;
            this.AddTransaction(new Transaction()
            {
                Amount = amount,
                Balance = this.Balance,
                Description = "Deposit",
                PostedDate = DateTime.Now,
                Status = TransactionStatus.Cleared,
                Type = TransactionType.Deposit
            });
            return true;
        }

        public virtual double GetBalance()
        {
            return Balance;
        }

        protected void AddTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return transactions;
        }
    }
}
