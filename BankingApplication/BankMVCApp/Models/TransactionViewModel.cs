using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankMVCApp.Models
{
    public class TransactionViewModel
    {
        [Required(ErrorMessage = "Enter a amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage ="Select Transation Type")]
        public char TransactionType { get; set; }

    }
}