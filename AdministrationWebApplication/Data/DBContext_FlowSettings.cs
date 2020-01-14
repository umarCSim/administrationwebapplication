using Microsoft.EntityFrameworkCore;
using AdministrationWebApplication.Models.Shared.Settings;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_FlowSettings : DerivedDBContext
    {
        public DBContext_FlowSettings(DbContextOptions<DBContext_FlowSettings> options)
            : base(options) { }

        public virtual DbSet<FlowSettingsView> FlowSettingsView { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdministrationWebApplicationDB");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlowSettingsView>(entity =>
            {
                entity.HasKey("SettingId");

                entity.ToView("FlowSettings_View", "Electric_Balancing");

                entity.Property(e => e.SettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue).HasColumnType("sql_variant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
