using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FMS.DAL.Models
{
    [Table("tblBayportData")]
    public partial class TblBayportData
    {
        [Key]
        [Column(TypeName = "smalldatetime")]
        public DateTime SampleDate { get; set; }
        [Key]
        [Column(TypeName = "smalldatetime")]
        public DateTime TimeSlot { get; set; }
        [Key]
        [StringLength(100)]
        public string SamplePoint { get; set; }
        [Key]
        [StringLength(2)]
        public string SampleType { get; set; }
        [Key]
        [StringLength(100)]
        public string Parameter { get; set; }
        [Key]
        [StringLength(30)]
        public string GeneratedBy { get; set; }
        [Key]
        [StringLength(40)]
        public string Method { get; set; }
        [Key]
        [StringLength(2)]
        public string Shift { get; set; }
        [Column("SampleID")]
        [StringLength(20)]
        public string SampleId { get; set; }
        public double? Result { get; set; }
        [StringLength(20)]
        public string StringResult { get; set; }
        [StringLength(20)]
        public string Units { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        [Column("MDL")]
        public double? Mdl { get; set; }
        [Column("ND")]
        [StringLength(2)]
        public string Nd { get; set; }
        [Column("DF")]
        public double? Df { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TestDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TestTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SampleTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? RecdDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferDate { get; set; }
        [StringLength(20)]
        public string Filtered { get; set; }
        public double? Volume { get; set; }
        [Column("COCNumber")]
        public int? Cocnumber { get; set; }
        [Column("BPCOC")]
        public int? Bpcoc { get; set; }
        public string Comments { get; set; }
        [Column("CAS")]
        [StringLength(20)]
        public string Cas { get; set; }
        public string Reason { get; set; }
        public bool? IsQaQc { get; set; }
        [Column("CalcQC")]
        public double? CalcQc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FinalValidDate { get; set; }
        [StringLength(20)]
        public string FinalValidInitials { get; set; }
        [Column("CLBilled")]
        [StringLength(6)]
        public string Clbilled { get; set; }
        [StringLength(20)]
        public string Lot { get; set; }
        [Column("QTA")]
        [StringLength(20)]
        public string Qta { get; set; }
        [StringLength(20)]
        public string Analyst { get; set; }
        public double? Cost { get; set; }
        public string FacilityComments { get; set; }
        public string OperatorRemarks { get; set; }
        [StringLength(20)]
        public string OpInitials { get; set; }
        public bool? DontUseForReporting { get; set; }
        [StringLength(50)]
        public string EntBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntDt { get; set; }
        [StringLength(50)]
        public string ModBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDt { get; set; }
        public short? TransferInsertSuccess { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransferInsertDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransfeDataLastModDate { get; set; }
        public short? TransfeDataModFlag { get; set; }
        [Column("TransferredToBDM")]
        [StringLength(1)]
        public string TransferredToBdm { get; set; }
        [Column("SCODE1")]
        [StringLength(4)]
        public string Scode1 { get; set; }
        [Column("isBillingAvg")]
        public short? IsBillingAvg { get; set; }
        public short? TexToxFlag { get; set; }
        public short? PriPollutantFlag { get; set; }
    }
}
