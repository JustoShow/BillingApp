using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FMS.DAL.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FMS.DAL.Data
{
    public partial class FMS_BPContext : DbContext
    {
        public FMS_BPContext()
        {
        }

        public FMS_BPContext(DbContextOptions<FMS_BPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBayportData> TblBayportData { get; set; }
        public virtual DbSet<TblFlows> TblFlows { get; set; }
        public virtual DbSet<TblSamplePoints> TblSamplePoints { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=BP-2018\\SQLEXPRESS;Initial Catalog=FMS_BP;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBayportData>(entity =>
            {
                entity.HasKey(e => new { e.SampleDate, e.TimeSlot, e.SamplePoint, e.SampleType, e.Parameter, e.GeneratedBy, e.Method, e.Shift })
                    .HasName("PK_tblBayportDataNew");

                entity.Property(e => e.SampleType).IsUnicode(false);

                entity.Property(e => e.Parameter).IsUnicode(false);

                entity.Property(e => e.GeneratedBy).IsUnicode(false);

                entity.Property(e => e.Method).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Analyst).IsUnicode(false);

                entity.Property(e => e.Cas).IsUnicode(false);

                entity.Property(e => e.Clbilled).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.EntBy).IsUnicode(false);

                entity.Property(e => e.FacilityComments).IsUnicode(false);

                entity.Property(e => e.Filtered).IsUnicode(false);

                entity.Property(e => e.FinalValidInitials).IsUnicode(false);

                entity.Property(e => e.Lot).IsUnicode(false);

                entity.Property(e => e.ModBy).IsUnicode(false);

                entity.Property(e => e.Nd).IsUnicode(false);

                entity.Property(e => e.OpInitials).IsUnicode(false);

                entity.Property(e => e.OperatorRemarks).IsUnicode(false);

                entity.Property(e => e.Qta).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.StringResult).IsUnicode(false);

                entity.Property(e => e.TransferredToBdm).IsUnicode(false);

                entity.Property(e => e.Units).IsUnicode(false);
            });

            modelBuilder.Entity<TblFlows>(entity =>
            {
                entity.HasKey(e => new { e.Scode, e.Date, e.FlowTimeSlot })
                    .HasName("PK_tblFlows_1");

                entity.Property(e => e.Scode).IsUnicode(false);

                entity.Property(e => e.FlowTimeSlot).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<TblSamplePoints>(entity =>
            {
                entity.HasKey(e => new { e.SamplePoint, e.Scode })
                    .HasName("PK_tblSamplePoints_01262018");

                entity.Property(e => e.SamplePoint).IsUnicode(false);

                entity.Property(e => e.Scode).IsUnicode(false);

                entity.Property(e => e.AddToMain)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AutoReport)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlanketShift).IsUnicode(false);

                entity.Property(e => e.Cs)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Customer).IsUnicode(false);

                entity.Property(e => e.DailyGpm)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DoGridShift).IsUnicode(false);

                entity.Property(e => e.DoGridShift2).IsUnicode(false);

                entity.Property(e => e.DoShift).IsUnicode(false);

                entity.Property(e => e.DoUpShift).IsUnicode(false);

                entity.Property(e => e.EnterFlow)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FinanceCode)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasTotalizer)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nh3Shift).IsUnicode(false);

                entity.Property(e => e.Operator)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Past1).IsUnicode(false);

                entity.Property(e => e.Past2).IsUnicode(false);

                entity.Property(e => e.Past3).IsUnicode(false);

                entity.Property(e => e.Past4).IsUnicode(false);

                entity.Property(e => e.Past5).IsUnicode(false);

                entity.Property(e => e.PhShift).IsUnicode(false);

                entity.Property(e => e.ReportFormat).IsUnicode(false);

                entity.Property(e => e.ReportScode).IsUnicode(false);

                entity.Property(e => e.StreamName).IsUnicode(false);

                entity.Property(e => e.SvShift).IsUnicode(false);

                entity.Property(e => e.Tagname1).IsUnicode(false);

                entity.Property(e => e.Tagname2).IsUnicode(false);

                entity.Property(e => e.Tagname3).IsUnicode(false);

                entity.Property(e => e.TempShift).IsUnicode(false);

                entity.Property(e => e.TocShift).IsUnicode(false);

                entity.Property(e => e.Topic1).IsUnicode(false);

                entity.Property(e => e.TssShift).IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WeeklyGpm)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
