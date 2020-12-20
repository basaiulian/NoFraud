using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagement.Entities
{
    public class BankAccount
    {
        [Column("id", TypeName = "int")]
        public string Id { get; set; }

        [Column("token_id", TypeName = "int")]
        public int TokenID { get; set; }

        [Column("balance", TypeName = "double")]
        public double Balance { get; set; }

        [Column("account_type", TypeName = "string")]
        public string AccountType { get; set; }

        [Column("user_id", TypeName = "int")]
        public int UserId { get; set; }

        public ICollection<Card> CardList { get; set; } = new List<Card>();
/*
        public bool Withdraw(double amount)
        {
            if (Balance >= amount)
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

*/    }
}
