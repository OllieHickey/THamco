using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ThreeAmigos.Store.Models
{
    public class SelectionBoxModel
    {
        [Key]
        public int SelectionBoxID { get; set; }

        public int ProviderID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public virtual bool Active { get; set; }
    }
}