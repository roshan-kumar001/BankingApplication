using BankingApplication.Enums;
using System;

namespace BankingApplication.Classes
{
    class Savings : BaseAccount
    {
        public double MinimumBalance { get; set; }

        public override void Initialize()
        {
            this.MinimumBalance = 100;
        }

        public override bool Withdraw(double amount)
        {
            if ((Balance - amount) < this.MinimumBalance)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                AddTransaction(new Transaction()
                {
                    Amount = amount,
                    Balance = this.Balance,
                    Description = "Withdrawal",
                    PostedDate = DateTime.Now,
                    Status = TransactionStatus.Cleared,
                    Type = TransactionType.Withdrawal
                });
                return true;
            }
        }
    }
}
