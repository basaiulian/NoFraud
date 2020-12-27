using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPaymentManagementApp.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

       
        public string Email { get; set; }
     
      
        public string PhoneNumber { get; set; }
       
       
        public string Address { get; set; }

        public ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    }
}