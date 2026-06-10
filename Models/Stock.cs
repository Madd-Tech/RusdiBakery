using System;
using System.Collections.Generic;
using System.Text;

namespace RusdiBakery.Models
{
    public class Stock
    {
        public int IdStock { get; set; }
        public int? IdProduct { get; set; }
        public int? StockQty { get; set; }

        // Navigation Property
        public Product? Product { get; set; }

    }
}
