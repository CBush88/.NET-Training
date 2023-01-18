using System.ComponentModel.DataAnnotations.Schema;

namespace DemoShop.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
    }
}
