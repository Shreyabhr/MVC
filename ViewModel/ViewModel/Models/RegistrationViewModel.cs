using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage ="Please enter name")]
        [ExcludeCharAttribute("/.,!@#$%", ErrorMessage= "Name contains invalid character.")]
        public string Name
        {
            get; set;
        }

        [Required(ErrorMessage = "Please enter email")]
        [RegularExpression("[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]{2,4}", ErrorMessage ="Please enter a valid email")]
        public string Email
        {
            get; set;
        }

        [Range(18,25,ErrorMessage ="Please enter valid age")]
        public int Age
        {
            get;set;
        }

        [Range(15000,Double.MaxValue,ErrorMessage ="sal should be greater that 15000")]
        public double Salary
        {
            get;set;
        }
    }
}