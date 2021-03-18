using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FMS.DAL.Models
{
    [Table("tblFlows")]
    public partial class TblFlows
    {
        [Key]
        [Column("SCODE")]
        [StringLength(4)]
        public string Scode { get; set; }
        [Key]
        [Column("DATE", TypeName = "smalldatetime")]
        public DateTime Date { get; set; }
        [Key]
        [StringLength(19)]
        public string FlowTimeSlot { get; set; }
        [Column("MG")]
        public double? Mg { get; set; }
        public short? Diverted { get; set; }
        public long? Totalizer { get; set; }
        [Column("PLC")]
        public short? Plc { get; set; }
        [StringLength(100)]
        public string Comments { get; set; }
        public bool? IsMeterChanged { get; set; }
        [StringLength(50)]
        public string EntBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EntDt { get; set; }
        [StringLength(50)]
        public string ModBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModDt { get; set; }
    }
}
