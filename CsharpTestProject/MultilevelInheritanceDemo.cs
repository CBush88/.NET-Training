using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    internal class MultilevelInheritanceDemo
    {
        // main parent class
        class A
        {
            public void method1()
            {
                Console.WriteLine("This is the method of class A");
            }
        }
        class B : A
        {
            public void method2()
            {
                Console.WriteLine("This is the method of class B");
            }
        }
        class C : B
        {
            public void method3()
            {
                Console.WriteLine("This is the method of class C");
            }
        }
        class D : C
        {
            public void method4()
            {
                Console.WriteLine("This is the method of class D");
            }
        }
        static void Main(string[] args)
        {
            D d = new D();
            d.method1();
            d.method2();
            d.method3();
            d.method4();
            Console.ReadKey();
        }
    }
}
