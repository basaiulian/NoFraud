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

        public double Balance { get; set; }

        [Required]
        public string AccountType { get; set; }

        public int UserId { get; set; }

    }
}
