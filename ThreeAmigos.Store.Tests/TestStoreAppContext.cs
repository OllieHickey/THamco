using System;
using System.Data.Entity;
using ThreeAmigos.Store.DAL;
using ThreeAmigos.Store.Models;

namespace ThreeAmigos.Store.Tests
{
    public class TestStoreAppContext : IStoreAppContext
    {
        public TestStoreAppContext()
        {
            this.Products = new TestProductDbSet();
        }

        public DbSet<ProductViewModel> Products { get; set; }

        public int SaveChanges()
        {
            return 0;
        }

        public void MarkAsModified(ProductViewModel item) { }
        public void Dispose() { }
    }
}