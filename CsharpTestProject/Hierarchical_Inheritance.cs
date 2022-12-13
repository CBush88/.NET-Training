using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    class A
    {
        public void a()
        {
            Console.WriteLine("a");
        }
    }
    class B:A 
    {
        public void b() 
        { 
            Console.WriteLine("b"); 
        }
    }
    class C:A 
    {
        public void c()
        {
            Console.WriteLine("c");
        }
    }
    class D:B 
    {
        public void d()
        {
            Console.WriteLine("d");
        }
    }
    class E:C 
    {
        public void e()
        {
            Console.WriteLine("e");
        }
    }
    internal class Hierarchical_Inheritance
    {
        static void Main(string[] args)
        {
            D d = new D();
            E e = new E();

            Console.WriteLine("Methods for D:");
            d.a();
            d.b();
            d.d();

            Console.WriteLine("Methods for E:");
            e.a();
            e.c();
            e.e();

            Console.ReadKey();
        }
    }
}
