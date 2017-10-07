using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCWebApp2.Models
{
    public class PaymentInfo
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }

        [CreditCard]
        public string CardNumber { get; set; }

        [Required]
        [Range(1, 10)]
        public int ExpireMonth { get; set; }

        [Required]
        [Range(2017, 2020)]
        public int ExpireYear { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
