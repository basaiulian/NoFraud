using System;
using System.Collections.Generic;

namespace NoFraud.Entity
{
    public class User
    {
        public Guid Uid { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public List<BankAccount> BankAccounts { get; }

        void AddBankAccount(BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
        }

        void RemoveBankAccount(BankAccount bankAccount)
        {
            BankAccounts.Remove(bankAccount);
        }



    }
}
