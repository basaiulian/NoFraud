using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPaymentManagementApp.Model
{
    public class BankAccount
    {
        public string Id { get; set; }
        [Required]
        public string BankName { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }
        public int UserId { get; set; }
        public ICollection<Card> CardList { get; set; } = new List<Card>();

    }
}
