using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CsharpTestProject
{
    class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }

    class ReflectPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }

    internal class ReflectionDemo
    {
        static void Main(string[] args)
        {
            Type type = typeof(Products);
            PropertyInfo[] propertiesInfo = type.GetProperties();
            foreach (PropertyInfo propertyInfo in propertiesInfo)
            {
                Console.WriteLine("Property: " + propertyInfo.Name);
            }

            Console.WriteLine();

            Type type2 = typeof(ReflectPerson);
            PropertyInfo[] personPropInfo = type2.GetProperties();
            foreach(PropertyInfo propertyInfo in personPropInfo)
            {
                Console.WriteLine(propertyInfo.Name);
            }
        }
    }
}
