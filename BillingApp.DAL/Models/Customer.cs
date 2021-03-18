using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingApp.DAL.Models
{
    [Table("Customer", Schema = "billing")]
    public class Customer
    {
        [Key]
        public int FinanceCode { get; set; }
        public string Name { get; set; }
        public ICollection<Stream> Streams { get; set; }
    }
}
