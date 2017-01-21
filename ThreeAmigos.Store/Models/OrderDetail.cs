using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeAmigos.Store.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int Order { get; set; }
        public int GiftWrapID { get; set; }
        public int SelectionBoxID { get; set; }
        public int Quantity { get; set; }


    }
}