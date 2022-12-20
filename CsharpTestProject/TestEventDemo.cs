using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace CsharpTestProject
{
    public delegate void EventHandler(object sender, EventArgs e);

    public class Publisher : ArrayList
    {
        public event EventHandler ProductAddedInfo;
        protected virtual void OnChanged(EventArgs e)
        {
            if(ProductAddedInfo!= null)
            {
                ProductAddedInfo(this, e);
            }
        }
        public override int Add(object product)
        {
            int added = base.Add(product);
            OnChanged(EventArgs.Empty);
            return added;
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }

    public class Subscriber
    {
        private Publisher publishers;
        public Subscriber(Publisher publisher)
        {
            this.publishers = publisher;
            publishers.ProductAddedInfo += publishers_ProductAddedInfo;
        }
        void publishers_ProductAddedInfo(object sender, EventArgs e)
        {
            if(sender == null)
            {
                Console.WriteLine("No new Product Added");
                return;
            }
            else
            {
                Console.WriteLine("A new Product Added");
            }
        }
        public void UnSubscribeEvent()
        {
            publishers.ProductAddedInfo-= publishers_ProductAddedInfo;
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
    }

    public class Publisher2 : ArrayList
    {
        public event EventHandler ListUpdated;
        protected virtual void OnChanged(EventArgs e)
        {
            if (ListUpdated != null)
            {
                ListUpdated(this, e);
            }
        }
        public override int Add(object listItem)
        {
            int added = base.Add(listItem);
            OnChanged(EventArgs.Empty);
            return added;
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }

        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }

    public class Subscriber2
    {
        private Publisher2 publishers;
        public Subscriber2(Publisher2 publisher)
        {
            this.publishers = publisher;
            publishers.ListUpdated += publishers_ListUpdated;
        }
        void publishers_ListUpdated(object sender, EventArgs e)
        {
            if (sender == null)
            {
                Console.WriteLine("No Updates");
                return;
            }
            else
            {
                Console.WriteLine("The List has been updated");
            }
        }
        public void UnSubscribeEvent()
        {
            publishers.ListUpdated -= publishers_ListUpdated;
        }
    }

    internal class TestEventDemo
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber(publisher);

            publisher.Add(new Product
            {
                ProductName = "Product",
                Price=120
            });
            publisher.Add(new Product
            {
                ProductName = "Product2",
                Price = 200
            });

            subscriber.UnSubscribeEvent();
            Console.ReadKey();

            Publisher2 publisher2 = new Publisher2();
            Subscriber2 subscriber2 = new Subscriber2(publisher2);

            publisher2.Add(1);
            publisher2.Add(2);
            publisher2.Add(3);

            subscriber2.UnSubscribeEvent();
            Console.ReadKey();

        }
    }

}
