using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThreeAmigos.Store.Models
{
    public class Brand
    {
        public int ID { get; set; }

        public int ProviderID { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }
    }
}