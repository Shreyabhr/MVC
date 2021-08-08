using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model
{
    public class Account
    {
        [Key]
        public Guid id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public virtual List<Transaction> Transactions {get;set;}
    }
}
