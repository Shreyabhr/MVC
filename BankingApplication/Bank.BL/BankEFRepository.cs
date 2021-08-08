using Bank.Model;
using Book.IBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.BL
{
    public class BankEFRepository : IBankRepository
    {
        public void DoTrasanction(string name, string password, double balance, char type)
        {
            throw new NotImplementedException();
        }

        public List<BankTransaction> GetTransactions(string name)
        {
            throw new NotImplementedException();
        }

        public string Login(string name, string password)
        {
            throw new NotImplementedException();
        }

        public void Register(string name, double balance, string password)
        {
            throw new NotImplementedException();
        }
    }
}
