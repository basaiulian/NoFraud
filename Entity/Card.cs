using System;

namespace NoFraud.Entity
{
    public class Card
    {
        public Guid Uid { get; set; }
        public int Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PinCode { get; set; }
        public int CvvCode { get; set; }
        public Guid OwnerId { get; set; }
        public string Bank { get; set; }
    }
}
