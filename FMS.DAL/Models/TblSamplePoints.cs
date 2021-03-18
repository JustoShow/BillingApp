using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FMS.DAL.Models
{
    [Table("tblSamplePoints")]
    public partial class TblSamplePoints
    {
        [Key]
        [StringLength(50)]
        public string SamplePoint { get; set; }
        [Key]
        [Column("SCode")]
        [StringLength(4)]
        public string Scode { get; set; }
        [StringLength(2)]
        public string Type { get; set; }
        [StringLength(1)]
        public string AutoReport { get; set; }
        [StringLength(10)]
        public string ReportFormat { get; set; }
        [Column("DailyGPM")]
        [StringLength(1)]
        public string DailyGpm { get; set; }
        [Column("WeeklyGPM")]
        [StringLength(1)]
        public string WeeklyGpm { get; set; }
        [StringLength(100)]
        public string Customer { get; set; }
        [Column("CS")]
        [StringLength(1)]
        public string Cs { get; set; }
        [StringLength(50)]
        public string StreamName { get; set; }
        [StringLength(1)]
        public string EnterFlow { get; set; }
        public int? SortOrder { get; set; }
        [StringLength(50)]
        public string Tagname1 { get; set; }
        [StringLength(20)]
        public string Topic1 { get; set; }
        [StringLength(20)]
        public string Tagname2 { get; set; }
        [StringLength(20)]
        public string Tagname3 { get; set; }
        [StringLength(10)]
        public string Past1 { get; set; }
        [StringLength(10)]
        public string Past2 { get; set; }
        [StringLength(10)]
        public string Past3 { get; set; }
        [StringLength(10)]
        public string Past4 { get; set; }
        [StringLength(10)]
        public string Past5 { get; set; }
        [StringLength(6)]
        public string FinanceCode { get; set; }
        [StringLength(1)]
        public string Operator { get; set; }
        [StringLength(1)]
        public string HasTotalizer { get; set; }
        [StringLength(1)]
        public string AddToMain { get; set; }
        public long? RollOver { get; set; }
        public long? Multiplier { get; set; }
        [Column("IsTOC")]
        public int? IsToc { get; set; }
        [Column("IsTSS")]
        public int? IsTss { get; set; }
        public int? IsDo { get; set; }
        public int? IsDoUptake { get; set; }
        public int? TocOrder { get; set; }
        public int? TssOrder { get; set; }
        public int? DoUpOrder { get; set; }
        public int? DoOrder { get; set; }
        [StringLength(1)]
        public string TocShift { get; set; }
        [StringLength(1)]
        public string TssShift { get; set; }
        [StringLength(1)]
        public string DoShift { get; set; }
        [StringLength(1)]
        public string DoUpShift { get; set; }
        [StringLength(1)]
        public string Nh3Shift { get; set; }
        [StringLength(1)]
        public string PhShift { get; set; }
        [StringLength(1)]
        public string SvShift { get; set; }
        [StringLength(1)]
        public string BlanketShift { get; set; }
        [StringLength(1)]
        public string TempShift { get; set; }
        [StringLength(1)]
        public string DoGridShift { get; set; }
        [StringLength(1)]
        public string DoGridShift2 { get; set; }
        [StringLength(4)]
        public string ReportScode { get; set; }
    }
}
