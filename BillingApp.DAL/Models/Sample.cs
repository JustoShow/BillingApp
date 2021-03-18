using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingApp.DAL.Models
{
    [Table("Samples", Schema = "billing")]
    public class Sample
    {
        public int ID { get; set; }
        public string Attention { get; set; }
        public string ITNotes { get; set; }
        public string ManagerNotes { get; set; }
        public string Scode { get; set; }
        public DateTime SampleDate { get; set; }
        public bool ClearFlow { get; set; }
        public double Flow { get; set; }
        public bool AvgFlow { get; set; }
        public string LapSampleNote { get; set; }
        public double pH { get; set; }
        public string LabPhNote { get; set; }
        public int TOC { get; set; }
        public int TOCLbs { get; set; }
        public bool AvgTOC { get; set; }
        public int TSS { get; set; }
        public int TSSLbs { get; set; }
        public bool AvgTSS { get; set; }
        public int TN { get; set; }
        public int TNLbs { get; set; }
        public double NO3 { get; set; }
        public int NO3Lbs { get; set; }
        public int BOD { get; set; }
        public int BODLbs { get; set; }
        public int NH3 { get; set; }
        public int NH3Lbs { get; set; }
        public bool Approve { get; set; }
        public bool Adjusted { get; set; }

    }
}
