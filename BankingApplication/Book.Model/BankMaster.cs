using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class BankMaster
    {
        private string _name;
        private double _balance;
        private string _password;

        public string Name
        {
            get;set;
        }

        public double Balance
        {
            get;set;
        }

        public string password
        {
            get;set;
        }
    }
}
