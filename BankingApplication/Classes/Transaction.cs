using BankingApplication.Enums;
using System;

namespace BankingApplication.Classes
{
    public class Transaction
    {
        public DateTime PostedDate { get; set; }
        public string Description { get; set; }
        public TransactionType Type { get; set; }
        public TransactionStatus Status { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
    }
}
