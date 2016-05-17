using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BaylorSample.Entities;

namespace BaylorSample.Data
{
    public class NorthwindDBContext : DbContext
    {
        public NorthwindDBContext() : base("northwind")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(x => x.CustomerID).ToTable("Customers");

            base.OnModelCreating(modelBuilder);
        }

    }
}