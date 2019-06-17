using valkyrieIMS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace valkyrieIMS.Data {
    public class valkyrieContext: DbContext {
        public valkyrieContext(DbContextOptions<valkyrieContext> options) : base(options) {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public DbSet<SaleReceipt> SaleReceipts { get; set; }

    }
}