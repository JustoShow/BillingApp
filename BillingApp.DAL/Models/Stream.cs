using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingApp.DAL.Models
{
    [Table("Streams", Schema = "billing")]
    public class Stream
    {
        [Key]
        public string Scode { get; set; }
        public string SamplePoint { get; set; }
        public ICollection<Sample> Samples { get; }
    }
}
