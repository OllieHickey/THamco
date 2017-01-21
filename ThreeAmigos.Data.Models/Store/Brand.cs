using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAmigos.Data.Models.Store
{
   public class Brand
    {
        /// <summary>
        /// Gets or sets the database ID for the brand.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of this brand as held by the provider.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the customer-facing name of the brand.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether or not the brand is currently enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the products within this brand.
        /// </summary>
        public List<Product> Products { get; set; }
    }
}
