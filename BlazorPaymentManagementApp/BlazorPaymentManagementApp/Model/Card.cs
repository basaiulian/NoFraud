using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPaymentManagementApp.Model
{
    public class Card
    {
        
        public int Id { get; set; }

        [Required]
        [MinLength(16)]
        [MaxLength(16)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "You can only use digits.")]
        public string Number { get; set; }

        [Required]
        [Range(typeof(DateTime), "12/12/2020", "12/12/2030", ErrorMessage = "Date is out of range")]
        public DateTime ExpirationDate { get; set; } = DateTime.Now;

        [Required]
        [MinLength(4)]
        [MaxLength(4)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "You can only use digits.")]
        public string PinCode { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "You can only use digits.")]
        public string CvvCode { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "You can only use letters.")]
        public string BankName { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "You can only use digits.")]
        public string OwnerId { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "You can only use digits.")]
        public string BankAccountId { get; set; }
    }
}
