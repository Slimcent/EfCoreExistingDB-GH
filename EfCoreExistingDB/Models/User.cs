using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreExistingDB.Models
{
    public partial class User
    {
        public User()
        {
            Accounts = new HashSet<Account>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
