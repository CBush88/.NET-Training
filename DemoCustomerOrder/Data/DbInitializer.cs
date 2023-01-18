using DemoShop.Models;

namespace DemoShop.Data
{
    public class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            var customers = new Customer[]
            {
                new Customer{CustomerFirstName="Rob",CustomerLastName="Robson",CustomerEmail="RobRobson@rob.com"},
                new Customer{CustomerFirstName="Tom",CustomerLastName="Thompson",CustomerEmail="TomThompson@tom.com"},
                new Customer{CustomerFirstName="James",CustomerLastName="Jameson",CustomerEmail="JamesJameson@gmail.com"}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var products = new Product[]
            {
                new Product{ProductName="Laptop", ProductQuantity=20,ProductPrice=900},
                new Product{ProductName="Desktop", ProductQuantity=8, ProductPrice=1250},
                new Product{ProductName="Keyboard", ProductQuantity=4, ProductPrice=95}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var orders = new Order[]
            {
                new Order{CustomerId=1, ProductId=1},
                new Order{CustomerId=2, ProductId=2},
                new Order{CustomerId=3, ProductId=3},
                new Order{CustomerId=1, ProductId=2},
                new Order{CustomerId=2, ProductId=3},
                new Order{CustomerId=3, ProductId=3}
            };
            foreach (Order o in orders)
            {
                context.Orders.Add(o);
            }

            context.SaveChanges();
        }
    }
}
