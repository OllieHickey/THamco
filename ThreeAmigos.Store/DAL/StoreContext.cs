using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ThreeAmigos.Store.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ThreeAmigos.Store.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("StoreContext")
        {
        }



        public DbSet<SelectionBoxModel> SelectionBoxes { get; set; }
        public DbSet<GiftWrapModel> GiftWrap { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<ProductViewModel> Products { get; set; }


    }
}