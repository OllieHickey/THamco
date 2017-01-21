using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeAmigos.Data;
using ThreeAmigos.Data.Models.Account;
using System.Data.Entity;

namespace ThreeAmigos.Data
{
    public class AccountDbModel : DbContext
    {
        // Your context has been configured to use a 'UserDbModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ThreeAmigos.Data.UserDbModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UserDbModel' 
        // connection string in the application configuration file.
        public AccountDbModel()
            : base("name=AccountDbModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AuthToken> AuthTokens { get; set; }
        public virtual DbSet<BrowsingHistoryEntry> BrowsingHistoryEntries { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}