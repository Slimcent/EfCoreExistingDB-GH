using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreExistingDB.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public virtual User User { get; set; }
    }
}
