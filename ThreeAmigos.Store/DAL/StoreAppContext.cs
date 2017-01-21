using System;
using System.Data.Entity;
using ThreeAmigos.Store.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ThreeAmigos.Store.DAL
{
    public class StoreAppContext : DbContext, IStoreAppContext
    {
        public StoreAppContext() : base("name=StoreAppContext")
        {
        }

        public DbSet<ProductViewModel> Products { get; set; }

        public void MarkAsModified(ProductViewModel item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}