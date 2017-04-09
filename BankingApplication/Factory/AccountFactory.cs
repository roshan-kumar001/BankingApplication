using BankingApplication.Classes;
using BankingApplication.Enums;

namespace BankingApplication.Factory
{
    public static class AccountFactory
    {
        public static BaseAccount GetAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Checkings: return new Checkings();
                case AccountType.Savings: return new Savings();
                case AccountType.CreditCard: return new CreditCard();
                default: return null;
            }
        }
    }
}
