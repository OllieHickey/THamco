using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeAmigos.Store.Models
{
    public class PriceViewModel
    {
        public int ID { get; set; }

        public int Quantity { get; set; }

        public decimal Amount { get; set; }
    }
}