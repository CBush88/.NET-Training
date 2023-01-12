using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_ProductCustomer.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int productQuantity { get; set; }
        public double productPrice { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}