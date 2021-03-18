using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingApp.DAL.Models
{
    [Table("Flags", Schema = "billing")]
    public class Flag
    {
        public DateTime BillingDate { get; set; }
        public DateTime DateAdded { get; set; }
        public bool Finalized { get; set; }
        public DateTime FinalizedDate { get; set; }
    }
}
