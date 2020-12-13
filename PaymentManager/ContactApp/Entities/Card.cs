using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        public int CvvCode { get; set; }

        [Column("owner_id", TypeName = "int")]
        public int OwnerId { get; set; }

        [Column("bank_name", TypeName = "string")]
        public string BankName { get; set; }

        [Column("bank_account_id", TypeName = "int")]
        public int BankAccountId { get; set; }

        public Card()
        {

        }

    }
}
