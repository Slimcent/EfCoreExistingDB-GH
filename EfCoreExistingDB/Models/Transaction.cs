using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreExistingDB.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Mode { get; set; }
        public decimal Amount { get; set; }
        public DateTime Time { get; set; }

        public virtual User User { get; set; }
    }
}
