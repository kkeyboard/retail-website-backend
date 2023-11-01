using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_app_1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public double CustomerAmount { get; set; }
    }
}