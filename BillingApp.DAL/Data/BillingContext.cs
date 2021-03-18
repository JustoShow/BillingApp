using BillingApp.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingApp.DAL.Data
{
    public class BillingContext : DbContext
    {
        public BillingContext()
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Stream> Streams { get; set; }
        public DbSet<Sample> Samples { get; set; }
    }
}
