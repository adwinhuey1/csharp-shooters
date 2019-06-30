namespace ValkyrieIMS.Models {
    public class Customer {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string GetFullName() => this.FirstName + " " + this.LastName;
    }
}    