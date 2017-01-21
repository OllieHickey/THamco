using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ThreeAmigos.Store.Models
{
    public interface IStoreAppContext : IDisposable
    {
        DbSet<ProductViewModel> Products { get; }
        int SaveChanges();
        void MarkAsModified(ProductViewModel item);
    }
}