using Microsoft.EntityFrameworkCore;
using AdministrationWebApplication.Models.Shared;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_FooterDetail : DerivedDBContext
    {
        public DBContext_FooterDetail(DbContextOptions<DBContext_FooterDetail> options)
            : base(options)
        {
        }

        public virtual DbSet<FooterDetailView> FooterDetailView { get; set; }

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
            modelBuilder.Entity<FooterDetailView>(entity =>
            {
                entity.HasKey("FileFooterId");

                entity.ToView("FooterDetail_View", "Electric_Balancing");

                entity.Property(e => e.FileFooterId).ValueGeneratedOnAdd();

                entity.Property(e => e.FkFileHeaderId).HasColumnName("FK_FileHeaderId");

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
