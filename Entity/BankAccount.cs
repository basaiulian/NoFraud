using System;
using System.Collections.Generic;

namespace NoFraud.Entity
{
    public class BankAccount
    {
        public Guid Uid { get; set; }
        public Guid TokenID { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public List<Card> CardList { get; set; }

        public bool Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Payment()
        {
            // TO DO: To be continued...
        }
    }
}
