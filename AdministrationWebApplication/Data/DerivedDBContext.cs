using Microsoft.EntityFrameworkCore;

namespace AdministrationWebApplication.Data
{
    public class DerivedDBContext : DbContext
    {
        public DerivedDBContext(DbContextOptions<DerivedDBContext> options) : base(options) { }

        protected DerivedDBContext(DbContextOptions options) : base(options) { }
    }
}
