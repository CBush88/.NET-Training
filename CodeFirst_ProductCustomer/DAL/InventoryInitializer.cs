using CodeFirst_ProductCustomer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst_ProductCustomer.DAL
{
    public class InventoryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<InventoryContext>
    {
        protected override void Seed(InventoryContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{customerId=1,customerFirstName="Rob",customerLastName="Robson",customerEmail="RobRobson@rob.com"},
                new Customer{customerId=2,customerFirstName="Tom",customerLastName="Thompson",customerEmail="TomThompson@tom.com"},
                new Customer{customerId=3,customerFirstName="James",customerLastName="Jameson",customerEmail="JamesJameson@gmail.com"}
            };
            customers.ForEach(c => context.Customers.Add(c));

            var products = new List<Product>
            {
                new Product{productId=1, productName="Laptop", productQuantity=20,productPrice=900},
                new Product{productId=2, productName="Desktop", productQuantity=8, productPrice=1250},
                new Product{productId=3, productName="Keyboard", productQuantity=4, productPrice=95}
            };
            products.ForEach(p => context.Products.Add(p));

            var orders = new List<Order>
            {
                new Order{orderId=1, customerId=1, productId=1},
                new Order{orderId=2,customerId=2, productId=2},
                new Order{orderId=3,customerId=3, productId=3},
                new Order{orderId=4,customerId=1, productId=2},
                new Order{orderId=5,customerId=2,productId=3},
                new Order{orderId=6,customerId=3, productId=3}
            };
            orders.ForEach(o => context.Orders.Add(o));

            context.SaveChanges();

        }
    }
}