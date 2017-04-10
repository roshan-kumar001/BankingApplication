using BankingApplication.Enums;
using System;

namespace BankingApplication.Classes
{
    class CreditCard : BaseAccount
    {
        public override bool Withdraw(double amount)
        {
            if ((Balance - amount) < 0)
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
