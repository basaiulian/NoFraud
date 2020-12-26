using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPaymentManagementApp.Model
{
    public class BankAccount
    {
        public string Id { get; set; }

        public string BankName { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; set; }

        public int UserId { get; set; }

        public ICollection<Card> CardList { get; set; } = new List<Card>();

    }
}
