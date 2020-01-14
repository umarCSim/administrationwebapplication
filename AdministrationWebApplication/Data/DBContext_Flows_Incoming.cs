using AdministrationWebApplication.Models.Flows.Incoming;
using Microsoft.EntityFrameworkCore;

namespace AdministrationWebApplication.Data
{
    public partial class DBContext_Flows_Incoming : DerivedDBContext
    {
        public DBContext_Flows_Incoming(DbContextOptions<DBContext_Flows_Incoming> options)
            : base(options) { }

        public virtual DbSet<CraR0121001IncomingView> CraR0121001IncomingView { get; set; }

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
            base.OnModelCreating(modelBuilder);

            /******************************************************************************************************************************************
            *******************************************CraR0121001IncomingView************************************************************************
            ******************************************************************************************************************************************/

            modelBuilder.Entity<CraR0121001IncomingView>(entity =>
            {
                entity.HasKey("FlowKeyId");

                entity.ToView("CRA_R0121001_Incoming_View", "Electric_Balancing");

                entity.Property(e => e.CraencryptionDetails)
                    .IsRequired()
                    .HasColumnName("CRAEncryptionDetails")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CraencryptionKey)
                    .IsRequired()
                    .HasColumnName("CRAEncryptionKey")
                    .HasMaxLength(30)
                    .IsUnicode(false);

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
            });

            //TODO Uncomment sequence model builder if required
            //modelBuilder.HasSequence("Sequence_Outgoing_Flow_Filename")
            //    .HasMin(0)
            //    .HasMax(999999999999)
            //    .IsCyclic();

            //modelBuilder.HasSequence("Sequence_Outgoing_Flow_Header")
            //    .HasMin(0)
            //    .HasMax(999999999)
            //    .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
