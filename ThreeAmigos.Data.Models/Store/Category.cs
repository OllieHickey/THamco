﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAmigos.Data.Models.Store
{
   public class Category
    {
        /// <summary>
        /// Gets or sets the database ID for this category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of this category as held by the provider.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the customer-facing name of this category.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether or not this category is currently enabled.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or sets the products within this category.
        /// </summary>
        public virtual List<Product> Products { get; set; }
    }
}
