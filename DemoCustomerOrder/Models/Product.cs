using System.ComponentModel.DataAnnotations.Schema;

namespace DemoShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

    }
}
