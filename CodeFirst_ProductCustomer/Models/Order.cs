using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_ProductCustomer.Models
{
    public class Order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}