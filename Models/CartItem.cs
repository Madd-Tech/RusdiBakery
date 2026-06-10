using System;
using RusdiBakery.Models;

namespace RusdiBakery.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Qty { get; set; }
        public double Price { get; set; }
        public double Subtotal => Qty * Price;
    }
}
