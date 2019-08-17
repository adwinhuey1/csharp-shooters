using System;
namespace valkyrieID.Models
{
    public class Product 
    {
        public int ProductId {get; set;}
        public string ProductName {get; set;}
        public int Quantity {get; set;}
        public DateTime DateAdded {get; set;}
        public string VendorName {get; set;}

        public decimal PurchasePrice {get; set;}
        public decimal SalePrice {get; set;}
        public string Unit {get; set;}
        public DateTime ExpirationDate {get; set;}
       
    }
}