using Microsoft.EntityFrameworkCore;
using AdministrationWebApplication.Models.Shared;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_FlowSummary : DerivedDBContext
    {
        public DBContext_FlowSummary(DbContextOptions<DBContext_FlowSummary> options)
            : base(options) { }

        public virtual DbSet<FlowSummaryView> FlowSummaryView { get; set; }

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
            modelBuilder.Entity<FlowSummaryView>(entity =>
            {
                entity.HasKey("HistoryId");

                entity.ToView("FlowSummary_View", "Electric_Balancing");

                entity.Property(e => e.FileType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FromParticipantId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.FromRoleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MessageRole)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToParticipantId)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ToRoleCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TransitType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
