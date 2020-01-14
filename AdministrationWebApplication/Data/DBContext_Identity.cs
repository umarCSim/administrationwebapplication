using AdministrationWebApplication.Models.Flows.Incoming;
using AdministrationWebApplication.Models.Shared;
using AdministrationWebApplication.Models.Shared.Settings;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_Identity : IdentityDbContext
    {
        public DBContext_Identity(DbContextOptions<DBContext_Identity> options)
            : base(options) {}
        protected DBContext_Identity(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdministrationWebApplicationDB");
            }
        }


    }
}
