using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BillingApp.DAL.Models
{
    [Table("Attentions", Schema = "billing")]
    public class Attention
    {
        public string AttentionType { get; set; }
    }
}
