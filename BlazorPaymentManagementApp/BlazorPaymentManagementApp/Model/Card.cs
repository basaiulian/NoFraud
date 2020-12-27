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
        [RegularExpression(@"^[0-9]{16,16}$", ErrorMessage = "Card number must contain exactly 16 digits.")]
        public string Number { get; set; }

        [Required]
        [Range(typeof(DateTime), "12/12/2020", "12/12/2030", ErrorMessage = "Date is out of range")]
        public DateTime ExpirationDate { get; set; } = DateTime.Now;

        [Required]
        [RegularExpression(@"^[0-9]{4,4}$", ErrorMessage = "Pin code must contain exactly 4 digits.")]
        public string PinCode { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3,3}$", ErrorMessage = "Cvv code must contain exactly 3 digits.")]
        public string CvvCode { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(20)]
        //[RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "You can only use letters.")]
        public string BankName { get; set; }

        public string OwnerId { get; set; }

        public string BankAccountId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = " The BankName field is required.")]
        [RegularExpression(@"^(?!(BankName)$).*$", ErrorMessage = "Please select a bank name.")]
        public string bankNameToSend { get; set; }

        [RegularExpression(@"^(?!(BankAccountId)$).*$", ErrorMessage = "Please select a bank account id.")]
        public string bankIdToSend { get; set; }
    }
}
