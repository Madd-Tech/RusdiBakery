using System;
using System.Collections.Generic;
using System.Text;

namespace RusdiBakery.Models
{
    public class Transaction
    {
        public int IdTransaction { get; set; }
        public string TransactionCode { get; set; } = string.Empty;
        public int? IdProduct { get; set; }
        public int? IdCustomer { get; set; }
        public int? Qty { get; set; }
        public double? Total { get; set; }

        // Navigation Properties
        public Product? Product { get; set; }
        public Customer? Customer { get; set; }
    }
}
