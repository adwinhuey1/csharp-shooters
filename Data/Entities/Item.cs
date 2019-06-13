using System;

namespace valkyrieIMS.Data.Entities {
    public class Item {
        public int ItemId {get; set;}
        public string ItemName {get; set;}
        public int Quantity {get; set;}
        public DateTime DateAdded {get; set;}
        public string VendorName {get; set;}

        public decimal PurchasePrice {get; set;}
        public decimal SalePrice {get; set;}
        public string Unit {get; set;}
        public DateTime ExpirationDate {get; set;}
    }
}