using Microsoft.EntityFrameworkCore;
using AdministrationWebApplication.Models.Shared;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_HeaderDetail : DerivedDBContext
    {
        public DBContext_HeaderDetail(DbContextOptions<DBContext_HeaderDetail> options)
            : base(options)
        {
        }

        public virtual DbSet<HeaderDetailView> HeaderDetailView { get; set; }

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
            modelBuilder.Entity<HeaderDetailView>(entity =>
            {
                entity.HasKey("FileHeaderId");

                entity.ToView("HeaderDetail_View", "Electric_Balancing");

                entity.Property(e => e.FileHeaderId).ValueGeneratedOnAdd();

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FromParticipantId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FromRoleCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MessageRole)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TestDataFlag)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ToParticipantId)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToRoleCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransitType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
