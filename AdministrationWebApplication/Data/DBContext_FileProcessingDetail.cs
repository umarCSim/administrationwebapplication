using Microsoft.EntityFrameworkCore;
using AdministrationWebApplication.Models.Shared;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_FileProcessingDetail : DerivedDBContext
    {
        public DBContext_FileProcessingDetail(DbContextOptions<DBContext_FileProcessingDetail> options)
            : base(options)
        {
        }

        public virtual DbSet<FileProcessingDetailView> FileProcessingDetailView { get; set; }

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
            modelBuilder.Entity<FileProcessingDetailView>(entity =>
            {
                entity.HasKey("HistoryId");

                entity.ToView("FileProcessingDetail_View", "Electric_Balancing");

                entity.Property(e => e.AppropriateAction)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodeType)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meaning)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Package)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseData)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
