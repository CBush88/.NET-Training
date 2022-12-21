using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingPractice_GenericCollectionsGUI
{
    public abstract class Shape
    {
        public abstract double Area();
        public virtual void Show()
        {
            Console.WriteLine("Show method of class Shape");
        }
    }
    public class Triangle: Shape
    {
        public double Base;
        public double Height;

        public override double Area()
        {
            return (Base * Height) / 2;
        }

        public Triangle(double tribase, double height)
        {
            Base = tribase;
            Height = height;
        }

        public override string ToString()
        {
            return $"Base: {Base} Height: {Height} Area: {Area()}";
        }
    }
    public class Rectangle: Shape 
    {
        public double Length;
        public double Width;

        public override double Area()
        {
            return Length * Width;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"Length: {Length} Width: {Width} Area: {Area()}";
        }
    }
}
