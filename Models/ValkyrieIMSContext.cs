using ValkyrieIMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ValkyrieIMS.Models {
    public class ValkyrieIMSContext: IdentityDbContext<User>{
        public ValkyrieIMSContext(DbContextOptions<ValkyrieIMSContext> options) : base(options) 
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<SaleReceipt> SaleReceipts { get; set; }

    }
}