using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace PaymentManagement
{
    public class Payment
    {
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("amount", TypeName = "float")]
        public float Amount { get; set; }

        [Column("currency", TypeName = "string")]
        public string Currency { get; set; }


        [Column("source_", TypeName = "string")]
        public string Source { get; set; }

        [Column("date_", TypeName = "date")]
        public DateTime Date { get; set; }

        [Column("destination", TypeName = "string")]
        public string Destination { get; set; }

        [Column("status", TypeName = "string")]
        public string Status { get; set; }

        [Column("latitude", TypeName = "float")]
        public float latitude { get; set; }

        [Column("longitude", TypeName = "float")]
        public float longitude { get; set; }
    }
}
