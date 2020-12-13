using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentManagement.Entities
{
    public class User
    {
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("username", TypeName = "string")]
        public string Username { get; set; }

        [Column("password", TypeName = "string")]
        public string Password { get; set; }

        [Column("email", TypeName = "string")]
        public string Email { get; set; }

        [Column("phone_number", TypeName = "string")]
        public string PhoneNumber { get; set; }

        [Column("address", TypeName = "string")]
        public string Address { get; set; }

        public ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

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
