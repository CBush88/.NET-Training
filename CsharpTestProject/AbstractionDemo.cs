using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    public abstract class Shape
    {
        public abstract void Area(); // abstract method

        public void Show() // non-abstract method
        {
            Console.WriteLine("Show method of class Shape");
        }
    }
    public class Triangle : Shape
    {
        public override void Area() //implementing abstract method of abstract class Shape
        {
            int b = 23;
            int h = 12;
            int area = (b * h) / 2;
            Console.WriteLine($"Area of a Triangle is: {area}");
        }
    }
    public class Rectangle : Shape
    {
        public override void Area()
        {
            int l = 23;
            int w = 12;
            int area = l * w;
            Console.WriteLine($"Area of a Rectangle is {area}");
        }
    }
    internal class AbstractionDemo
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.Area();
            Rectangle rectangle = new Rectangle();
            rectangle.Show();
            rectangle.Area();
            Shape rect = new Rectangle();
            rect.Show();
            Console.ReadKey();
        }
    }
    public abstract class Device
    {
        public abstract void Description();
    }
    public class Laptop : Device
    {
        public override void Description()
        {
            Console.WriteLine("A lightweight and transportable Windows computer.");
        }
    }
}
