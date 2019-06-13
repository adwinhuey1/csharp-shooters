using System;
using System.Collections.Generic;

namespace valkyrieIMS.Data.Entities {
    public class PurchaseInvoice {
        public int InvoiceId { get; set; }
        public string VendorName { get; set; }
        public Item ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime InvoiceDate { get; set; }

        public ICollection<Item> Items { get; set; }
        public ICollection<Vendor> Vendors { get; set; }

    }
}