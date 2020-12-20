using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentManagement.Entities
{
    public class Card
    {
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("number", TypeName = "string")]
        public string Number { get; set; }
        
        [Column("expiration_date", TypeName = "DateTime")]
        public DateTime ExpirationDate { get; set; }

        [Column("pin_code", TypeName = "string")]
        public string PinCode { get; set; }

        [Column("cvvCode", TypeName = "string")]
        public string CvvCode { get; set; }

        [Column("owner_id", TypeName = "string")]
        public string OwnerId { get; set; }

        [Column("bank_name", TypeName = "string")]
        public string BankName { get; set; }

        [Column("bank_account_id", TypeName = "string")]
        public string BankAccountId { get; set; }

        public Card()
        {

        }

    }
}
