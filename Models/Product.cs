using System;
using System.Collections.Generic;
using System.Text;

namespace RusdiBakery.Models
{
    public class Product
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
