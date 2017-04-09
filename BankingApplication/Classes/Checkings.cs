using BankingApplication.Enums;
using System;

namespace BankingApplication.Classes
{
    class Checkings : BaseAccount
    {
        public double OverdraftLimit { get; set; }

        public override void Initialize()
        {
            // Get any default values from the DB.
            this.OverdraftLimit = 10;
        }

        public override bool Withdraw(double amount)
        {
            if ((Balance - amount) < (-this.OverdraftLimit))
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
