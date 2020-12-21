using System;

namespace BlazorPaymentManagementApp.Model
{
    public class Payment
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public string Currency { get; set; }
        public string Source { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Destination { get; set; }
    }
}
