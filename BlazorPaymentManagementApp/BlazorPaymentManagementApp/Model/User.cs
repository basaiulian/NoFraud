using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorPaymentManagementApp.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Username must have at least 5 characters.")]
        [MaxLength(12, ErrorMessage = "Username must have at most 12 characters.")]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must have at least 5 characters.")]
        [MaxLength(12, ErrorMessage = "Password must have at most 12 characters.")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        [MinLength(10, ErrorMessage = "Phone number must have at least 10 digits.")]
        [MaxLength(15, ErrorMessage = "Phone number must have at most 15 digits.")]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
    }
}