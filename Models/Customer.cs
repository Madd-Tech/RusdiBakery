using System;
using System.Collections.Generic;
using System.Text;

namespace RusdiBakery.Models
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
