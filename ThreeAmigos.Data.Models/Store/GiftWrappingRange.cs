﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeAmigos.Data.Models.Store
{
    public class GiftWrappingRange
    {
        /// <summary>
        /// Gets or sets the database ID for this gift-wrapping range.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ID of this gift-wrapping range as held by the provider.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the name of this gift-wrapping range.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the text-based description of this gift-wrapping range.
        /// </summary>
        public string Description { get; set; }
    }
}
