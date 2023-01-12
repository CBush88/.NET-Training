using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_ProductCustomer.Models
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string customerEmail { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}