using System;

namespace Book.Model
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public char TransactionType { get; set; }
        public Account Account { get; set; }
    }
}
