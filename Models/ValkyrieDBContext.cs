using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace valkyrieID.Models
{
    public class ValkyrieDBContext : IdentityDbContext
    {
        public ValkyrieDBContext(DbContextOptions<ValkyrieDBContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<SaleReceipt> SaleReceipts { get; set; }

    }
}
