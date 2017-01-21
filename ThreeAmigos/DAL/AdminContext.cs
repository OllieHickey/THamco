using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ThreeAmigos.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ThreeAmigos.DAL
{
    public class AdminContext : DbContext
    {

        public AdminContext() : base("AdminContext")
        {
        }
        
        public DbSet<Admin> AdminDetails { get; set; }

        public DbSet<Users> UserDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}