using System;
using System.Collections.Generic;

namespace ValkyrieIMS.Models {
    public class Invoice {
        public int InvoiceId { get; set; }
        public string VendorName { get; set; }
        public Product ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime InvoiceDate { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Vendor> Vendors { get; set; }

    }
}