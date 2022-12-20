using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTestProject
{
    internal class AttributeDemo
    {
        [Obsolete("This is the old method, use Method2 instead")]
        static void Method1()
        {
            Console.WriteLine("This is the old method");
        }
        static void Method2() 
        {
            Console.WriteLine("This is the new method");
        }
        static void Main(string[] args)
        {
            AttributeDemo.Method1();
            AttributeDemo.Method2();
            Console.ReadKey();
        }
    }
}
