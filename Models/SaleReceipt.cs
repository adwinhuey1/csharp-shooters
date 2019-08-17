using System;
using System.Collections.Generic;

namespace valkyrieID.Models {
    public class SaleReceipt {
        public int SaleReceiptId { get; set; }
        public DateTime ReceiptDate { get; set; }
        public Customer CustomerFirstName { get; set; }
        public Customer CustomerLastName { get; set; }
        public Product ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Customer> Customers { get; set; }
    

         

    }
}