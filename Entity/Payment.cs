using Nest;
using System;
namespace NoFraud.Entity
{
    public class Payment
    {
        public Guid Uid { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }

        public GeoCoordinate Location { get; set; }
    }
}
