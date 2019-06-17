using System;
using System.Collections.Generic;

namespace valkyrieIMS.Data.Entities {
    public class SaleReceipt {
        public int SaleReceiptId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }

        public ICollection<Product> Product { get; set; }
        public ICollection<Customer> Customers { get; set; }

         

    }
}